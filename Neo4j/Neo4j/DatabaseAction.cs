﻿using Neo4j.Driver.V1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4j
{
    class DatabaseAction:IDisposable
    {
        private readonly IDriver _driver;
        public DatabaseAction(IDriver driver) {
            _driver = driver;
        }

        public List<string> GetAllFactorLabels() {
            List<string> list = new List<string>();
            using (var session = _driver.Session())
            {
                var result = session.WriteTransaction(t =>
                    t.Run("match(n) return distinct labels(n) as label").ToList());
                foreach (var tem in result)
                {
                    string[] str;
                    str = JsonConvert.DeserializeObject<string[]>(JsonConvert.SerializeObject(tem[0]));
                    list.Add(str[0]);
                }
            }

            return list;
        }

        public List<string> GetFactorRelationShipByLabel (string label)
        {
            List<string> list = new List<string>();
            using (var session = _driver.Session())
            {
                var result = session.WriteTransaction(t => {
                    var temp = t.Run("match(n:"+label+")-[r]->(i) return distinct type(r) as type").ToList();              
                    return temp;
                });
                foreach (var tem in result)
                {
                    string str;
                    str = JsonConvert.DeserializeObject<string>(JsonConvert.SerializeObject(tem[0]));
                    list.Add(str);
                }
            }
            return list;
        }

        public List<object> GetFactorDataByLabel(string label)
        {
            List<object> list = new List<object>();
            using (var session = _driver.Session())
            {
                var result = session.WriteTransaction(t => {
                    var temp = t.Run("match(n:" + label + ") return n").ToList();
                    string str = JsonConvert.SerializeObject(temp);
                    return temp;
                });
                foreach (var tem in result)
                {
                    string str = JsonConvert.SerializeObject(tem[0].As<INode>().Properties);
                    object temp = JsonConvert.DeserializeObject<object>(str);

                    list.Add(temp);
                }
            }
            return list;
        }

        public void AddNewFactor(string factor, string features, string id, string name, string species)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(t =>
                {
                    //Console.WriteLine("Create (p:" + factor + "{" + factor.Substring(0, factor.Length - 1) + "ID:" + id.ToString() + ", Name:$name , Species:$species, Features:$features }) ");
                    t.Run("Create (p:"+factor+"{"+factor.Substring(0,factor.Length-1)+"ID:$id, Name:$name , Species:$species, Features:$features }) ", new {id,name,species,features});
                });
            }
        }

        public void AddNewFactorWithID(string factor, string features, string id, string name, string species)
        {
            using (var session = _driver.Session())
            {
                // get unique id
                string query="MERGE(id: UniqueId{ name: "+factor+"})"+
                "ON CREATE SET id.count = 1"+
                "ON MATCH SET id.count = id.count + 1"+
                "WITH id.count AS uid"+
                // create Person node
                "CREATE(p:"+factor+ "{"+ factor.Substring(0, factor.Length - 1) + "ID: uid, Features:" + features/*add all properties*/+"})"+
                "RETURN p AS "+factor;

                session.WriteTransaction(t =>
                {
                    t.Run(query);
                });
            }
        }

        public void DeleteFactorByID(string id,string factor)
        {
            Console.WriteLine(id);
            Console.WriteLine(factor);
            using (var session = _driver.Session()) {
                session.WriteTransaction(t => {
                    t.Run("match(p:"+factor+"{"+ factor.Substring(0, factor.Length - 1)+"ID:'"+id+"'}) detach delete p");
                });
            }
        }

        public void Dispose()
        {
            _driver?.Dispose();
        }
        
        public void UpdateFactor(string factor, string feature, string id, string name, string species)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx => {
                    string query = "match(p:" + factor + ") " +
                    "where p." + factor.Substring(0, factor.Length - 1) + "ID = $id " +
                    "Set p.Features = $feature, p.Name=$name, p.Species = $species";
                    Console.WriteLine(query);
                    tx.Run(query, new { id, feature, name, species });
                });
            }
        }

        public List<object> Search(string factor,string property, string pattern)
        {
            List<object> list = new List<object>();
            if (pattern != "")
            {
                using (var session = _driver.Session())
                {
                    session.WriteTransaction(tx =>
                    {
                        string prop = property;
                        pattern = (prop == "ID") ? pattern : ("'" + pattern + "'");
                        prop = (prop == "ID") ? (factor.Substring(0, factor.Length - 1) + "ID") : (prop);

                        var  result = tx.Run("match (n:" + factor + ") where n." + prop + "='"+ pattern + "' return n");
                        Console.WriteLine("match (n:" + factor + ") where n." + prop + "='" + pattern + "' return n");
                        foreach (var record in result)
                        {
                            Console.WriteLine(JsonConvert.SerializeObject(record));
                            var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                            list.Add(JsonConvert.DeserializeObject<object>(nodeProps));
                        }
                    });
                }
                return list;
            }
            else {
                return GetFactorDataByLabel(factor);
            }
        }
        public List<object> SearchByRelationship(string factor, string property, string pattern, string relation)
        {
            List<object> list = new List<object>();
            if (pattern != "")
            {
                using (var session = _driver.Session())
                {
                    session.WriteTransaction(tx =>
                    {
                        string prop = property;
                        pattern = (prop == "ID") ? pattern : ("'" + pattern + "'");
                        prop = (prop == "ID") ? (factor.Substring(0, factor.Length - 1) + "ID") : (prop);
                        Console.WriteLine("match (n:" + factor + ") -[r:" + relation + "]-(i) where n." + prop + "='" + pattern + "' return distinct i");
                        var result = tx.Run("match (n:" + factor + ") -[r:" + relation + "]->(i) where n." + prop + "='" + pattern + "' return i");

                        foreach (var record in result)
                        {
                            var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                            list.Add(JsonConvert.DeserializeObject<object>(nodeProps));
                        }
                    });
                }
                return list;
            }
            else
            {
                return GetFactorDataByLabel(factor);
            }
        }
    }
}
