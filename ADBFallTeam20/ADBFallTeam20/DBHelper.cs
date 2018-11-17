using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ADBFallTeam20
{
	public class DBHelper
	{
		public MyCouchClient Connect(string dbname) 
		{
			//Kết nối với server cùng với tài khoản và mật khẩu
			var client = new MyCouchClient("http://admin:admin@localhost:5984", dbname);
			return client;
		}
		public async Task<int> getId()
		{
			//Tạo ở server database qlbhnhom20
			var db = Connect("qlbhnhom20");
		
			var query = new QueryViewRequest("getList","getMax").Configure(q => q
			.Limit(1)
			.Descending(true)
			);
			
			ViewQueryResponse<string> result = await db.Views.QueryAsync<string>(query);
			return (int.Parse(result.Rows[0].Key.ToString())+1);
			
		}
		public async Task<EntityResponse<T>> InsertDoc<T>(T data) where T: class
		{
			var db = Connect("qlbhnhom20");
			var result = await db.Entities.PutAsync<T>(data);
			
			return result;
		}
		public async Task<List<T>> GetList<T>(string name = null) where T: class
		{
			var createview = @"{
				""views"": {
					""GetListProduct"": {
						""map"": ""function (doc) {\n if(doc.$doctype==\""product\""){\n emit(doc.name,{_id:doc._id,Name:doc.name,Sale:doc.sale,Price:doc.price,Unit:doc.unit,_rev:doc._rev} );\n }\n}""
					},
					""getMax"": {
						""map"": ""function (doc) {\n if(doc.$doctype==\""product\""){\n emit(doc._id);\n  }\n}""
					}
				},
				""language"": ""javascript""
			}";
			var db = Connect("qlbhnhom20");
			//var change = JObject.Parse(createview);
			var _rev = await db.Documents.GetAsync("_design/getList");
			if (_rev.Rev == null)
			{
				await db.Documents.PutAsync("_design/getList", createview);
			}
			//var cr = await db.Documents.PutAsync("_design/getList1", _rev.Rev, createview);
			
			var query = new QueryViewRequest("getList", "GetListProduct").Configure(q=>q
			.Limit(25)
			);
			if(name!= null)
			{
				query.StartKey = name;
				query.EndKey = GetStringGeater(name);
			}
			ViewQueryResponse<string> result = await db.Views.QueryAsync<string>(query);
			var data = result.Rows;
			List<T> listProduct = new List<T>();
			foreach(var i in data)
			{
				listProduct.Add(JsonConvert.DeserializeObject<T>(i.Value.ToString()));
			}
			
			return listProduct;
		}


		public void Update<T>(T data) where T: class
		{
			var db = Connect("qlbhnhom20");
			db.Entities.PutAsync(data).Wait(10);
		}
		public async void Delete<T>(T data) where T: class
		{
			var db = Connect("qlbhnhom20");
			await db.Entities.DeleteAsync(data);
		}

		public async Task<string> isId(string id)
		{
			var db = Connect("qlbhnhom20");
			var result = await db.Documents.GetAsync(id);
			if (result.IsSuccess)
			{
				return result.Rev.ToString();
			}
			else return "";
		}


		public async Task<List<T>> GetListInvoice<T>() where T : class
		{
			var createview = @"{
				""views"": {
					""GetListInvoice"": {
						""map"": ""function (doc) {\n if(doc.$doctype==\""invoice\""){\n emit(doc._id,{_id:doc._id,CustomerName:doc.customerName,Date:doc.date,_rev:doc._rev} );\n }\n}""
					},
					""GetListItem"":{
						""map"": ""function(doc) {\n  if (doc.$doctype == \""invoice\""){\n doc.itemList.forEach(function(item){\n emit(doc._id,item);\n });\n }\n}""
					}
				},
				""language"": ""javascript""
			}";
			var db = Connect("qlbhnhom20");
			var _rev = await db.Documents.GetAsync("_design/getInvoice");
			if (_rev.Rev==null)
			{
				await db.Documents.PutAsync("_design/getInvoice", createview);
			}
			var query = new QueryViewRequest("getInvoice", "GetListInvoice").Configure(q => q
			.Limit(25)
			);
			ViewQueryResponse<string> result = await db.Views.QueryAsync<string>(query);
			var data = result.Rows;
			List<T> listProduct = new List<T>();
			foreach (var i in data)
			{
				listProduct.Add(JsonConvert.DeserializeObject<T>(i.Value.ToString()));
			}

			return listProduct;
		}
		public string GetStringGeater(string a)
		{
			var b = new StringBuilder();
			foreach (char i in a)
			{
				if (i != a[a.Length-1])
				{
					b.Append(i);
				}
				else
				{
					int ch = Convert.ToInt32(i);
					ch++;
					b.Append((char)ch);
				}
			}

			return b.ToString();
		}
		public async Task<List<T>> GetListItem<T>(string id) where T : class
		{
			var db = Connect("qlbhnhom20");
			var query = new QueryViewRequest("getInvoice", "GetListItem").Configure(q => q
			.Limit(25)
			.Key(id)
			);
			ViewQueryResponse<string> result = await db.Views.QueryAsync<string>(query);
			var data = result.Rows;
			List<T> listItem = new List<T>();
			foreach (var i in data)
			{
				listItem.Add(JsonConvert.DeserializeObject<T>(i.Value.ToString()));
			}
			return listItem;
		}

	}
}
