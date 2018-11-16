using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jProject.model;
using Neo4j.Driver.V1;
using Newtonsoft.Json;

namespace Neo4jProject.database
{
    class DatabaseExecution:IDisposable
    {

        private readonly IDriver _driver;
       
        public DatabaseExecution(string uri, string username, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password));
            
        }

        public void Dispose()
        {
            _driver?.Dispose();
        }

        /* Producers section */
    
        public void PrintProducer(Producers producer)
        {
            Console.WriteLine("ProducerID: " + producer.ProducerID);
            Console.WriteLine("Name: " + producer.Name);
            Console.WriteLine("Species:" + producer.Species);
            Console.WriteLine("Features: " + producer.Features);
            Console.WriteLine(new String('-',20));
        }

        /// <summary>
        /// Import the string query statement which you want to retrieve a Producer from
        /// </summary>
        public Producers GetProducer(string statement)
        {
            Producers producer = new Producers();
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx=> 
                {
                    var result = tx.Run(statement);
                    var nodeObject = JsonConvert.SerializeObject(result.Select(node=>node[0].As<INode>().Properties).First());                    
                    producer = JsonConvert.DeserializeObject<Producers>(nodeObject);                    
                });
            }
            return producer;
        }

        public void GetAllProducers()
        {
            using (var session = _driver.Session())
            {
                List<Producers> producers = new List<Producers>();
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run("match (n:Producers) return n");
                    foreach (var record in result)
                    {
                        var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                        producers.Add(JsonConvert.DeserializeObject<Producers>(nodeProps));
                    }
                });

                foreach (Producers producer in producers)
                {
                    PrintProducer(producer);
                }
            }
        }

        public void AddProducer(Producers producer) {
            using (var session = _driver.Session()) {
                session.WriteTransaction(tx =>
                {
                    tx.Run("Create (p:Producers{ProducerID:$ProducerID, Name:$Name , Species:$Species, Feature:$Features }) ",new {producer.ProducerID,producer.Name,producer.Species,producer.Features});
                });
            }
        }

        public void DeleteProducer(Producers producer)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    tx.Run("match(p:Producers{ProducerID:$ProducerID}) detach delete p",new { producer.ProducerID });
                });
            }
        }

        public void DeleteProducerByRelationship(Producers producer)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    tx.Run("match(p:Producers{ProducerID:$ProducerID})-[r]-() delete r", new { producer.ProducerID });
                });
            }
        }
        
        public List<object> SearchProducerByRelationship(Producers producer,string relationtype)
        {
            List<object> producers = new List<object>();
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run("match ( n:Producers {ProducerID : $ProducerID})-[r:"+relationtype+"]-(x) return x",new {producer.ProducerID});
                    foreach (var record in result)
                    {
                        var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                        producers.Add(JsonConvert.DeserializeObject<object>(nodeProps));
                    }
                });
            }
            return producers;
        }

        public void UpdateProducer(int ID,Producers producer) {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx => {
                    string query = "match(p:Producers) " +
                    "where p.ProducerID = $ID " +
                    "Set p = $producer";
                    tx.Run(query, new { ID, producer});
                });
            }
        }
        /* End Producers section*/

        /* Begin PrimaryConsumers section */
        public void PrintPrimaryConsumers(PrimaryConsumers primary)
        {
            Console.WriteLine("PrimaryConsumerID: " + primary.PrimaryConsumerID);
            Console.WriteLine("Name: " + primary.Name);
            Console.WriteLine("Species: " + primary.Species);
            Console.WriteLine("Features: " + primary.Features);
            Console.WriteLine(new String('-', 20));
        }

        /// <summary>
        /// Import the string query statement which you want to retrieve a PrimaryConsumer from
        /// </summary>
        public PrimaryConsumers GetPrimaryConsumer(string statement)
        {
            PrimaryConsumers primary = new PrimaryConsumers();
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run(statement);
                    var nodeObject = JsonConvert.SerializeObject(result.Select(node => node[0].As<INode>().Properties).First());
                    primary = JsonConvert.DeserializeObject<PrimaryConsumers>(nodeObject);
                });
            }
            return primary;
        }

        public void GetAllPrimaryConsumers()
        {
            using (var session = _driver.Session())
            {
                List<PrimaryConsumers> primaries = new List<PrimaryConsumers>();
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run("match (n:PrimaryConsumers) return n");
                    foreach (var record in result)
                    {
                        var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                        primaries.Add(JsonConvert.DeserializeObject<PrimaryConsumers>(nodeProps));
                    }
                });

                foreach (PrimaryConsumers primary in primaries)
                {
                    PrintPrimaryConsumers(primary);
                }
            }
        }

        public void AddPrimaryConsumer(PrimaryConsumers producer)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    tx.Run("Create (p:PrimaryConsumers{PrimaryConsumerID:$PrimaryConsumerID, Name:$Name , Species:$Species, Feature:$Features }) ", new { producer.PrimaryConsumerID, producer.Name, producer.Species, producer.Features });
                });
            }
        }

        public void DeletePrimaryConsumer(PrimaryConsumers producer)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    tx.Run("match(p:Producers{PrimaryConsumerID:$PrimaryConsumerID}) detach delete p", new { producer.PrimaryConsumerID });
                });
            }
        }

        public void DeletePrimaryConsumerByRelationship(PrimaryConsumers producer)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    tx.Run("match(p:PrimaryConsumers{PrimaryConsumerID:$PrimaryConsumerID})-[r]-() delete r", new { producer.PrimaryConsumerID });
                });
            }
        }

        public List<object> SearchPrimaryConsumerByRelationship(PrimaryConsumers producer, string relationtype)
        {
            List<object> producers = new List<object>();
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run("match ( n:PrimaryConsumers {PrimaryConsumerID : $PrimaryConsumerID})-[r:" + relationtype + "]-(x) return x", new { producer.PrimaryConsumerID });
                    foreach (var record in result)
                    {
                        var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                        producers.Add(JsonConvert.DeserializeObject<object>(nodeProps));
                    }
                });
            }
            return producers;
        }

        public void UpdatePrimaryConsumer(int ID, PrimaryConsumers producer)
        {
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx => {
                    string query = "match(p:PrimaryConsumers) " +
                    "where p.PrimaryConsumerID = $ID " +
                    "Set p = $producer";
                    tx.Run(query, new { ID, producer });
                });
            }
        }

        /* End PrimaryConsumers section*/


        /* Begin SecondaryConsumers section*/
        public void PrintSecondaryConsumers(SecondaryConsumers secondary)
        {
            Console.WriteLine("SecondaryConsumerID: " + secondary.SecondaryConsumerID);
            Console.WriteLine("Name: " + secondary.Name);
            Console.WriteLine("Species: " + secondary.Species);
            Console.WriteLine("Features: " + secondary.Features);
            Console.WriteLine(new String('-', 20));
        }

        /// <summary>
        /// Import the string query statement which you want to retrieve a SecondaryConsumer from
        /// </summary>
        public SecondaryConsumers GetSecondaryConsumer(string statement)
        {
            SecondaryConsumers secondary = new SecondaryConsumers();
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run(statement);
                    var nodeObject = JsonConvert.SerializeObject(result.Select(node => node[0].As<INode>().Properties).First());
                    secondary = JsonConvert.DeserializeObject<SecondaryConsumers>(nodeObject);
                });
            }
            return secondary;
        }

        public void GetAllSecondaryConsumers()
        {
            using (var session = _driver.Session())
            {
                List<SecondaryConsumers> secondaries = new List<SecondaryConsumers>();
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run("match (n:SecondaryConsumers) return n");
                    foreach (var record in result)
                    {
                        var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                        secondaries.Add(JsonConvert.DeserializeObject<SecondaryConsumers>(nodeProps));
                    }
                });

                foreach (SecondaryConsumers secondary in secondaries)
                {
                    PrintSecondaryConsumers(secondary);
                }
            }
        }
        /*End SecondaryConsumers section*/


        /* Begin TertiaryConsumers section */
        public void PrintTertiaryConsumers(TertiaryConsumers tertiary)
        {
            Console.WriteLine("TertiaryConsumerID: " + tertiary.TertiaryConsumerID);
            Console.WriteLine("Name: " + tertiary.Name);
            Console.WriteLine("Species: " + tertiary.Species);
            Console.WriteLine("Features: " + tertiary.Features);
            Console.WriteLine(new String('-', 20));
        }


        /// <summary>
        /// Import the string query statement which you want to retrieve a TertiaryConsumer from
        /// </summary>
        public TertiaryConsumers GetTertiaryConsumer(string statement)
        {
            TertiaryConsumers tertiary = new TertiaryConsumers();
            using (var session = _driver.Session())
            {
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run(statement);
                    var nodeObject = JsonConvert.SerializeObject(result.Select(node => node[0].As<INode>().Properties).First());
                    tertiary = JsonConvert.DeserializeObject<TertiaryConsumers>(nodeObject);
                });
            }
            return tertiary;
        }

        public void GetAllTertiaryConsumers()
        {
            using (var session = _driver.Session())
            {
                List<TertiaryConsumers> tertiaries = new List<TertiaryConsumers>();
                session.WriteTransaction(tx =>
                {
                    var result = tx.Run("match (n:TertiaryConsumers) return n");
                    foreach (var record in result)
                    {
                        var nodeProps = JsonConvert.SerializeObject(record[0].As<INode>().Properties);
                        tertiaries.Add(JsonConvert.DeserializeObject<TertiaryConsumers>(nodeProps));
                    }
                });

                foreach (TertiaryConsumers tertiary in tertiaries)
                {
                    PrintTertiaryConsumers(tertiary);
                }
            }
        }
        /* End TertiaryConsumers section */
        
    }
}
