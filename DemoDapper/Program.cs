// See https://aka.ms/new-console-template for more information

using Dapper;
using DemoDapper;
using CaoCao.CoreBusiness.Models;
using System.Data;
using System.Data.SqlClient;

var connectStr = "Data Source=LAPTOP-D1OC4B0G;Initial Catalog=CaoCao;Integrated Security=True";

var da = new DataAccess(connectStr);

var results1 = da.Query<Product, dynamic>("SELECT * FROM Product", new { });

var results2 = da.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE ProductId=@ProductId",
                new { ProductID = "495" });

var sql = "";

//using (IDbConnection conn = new SqlConnection(connectStr))
//{
//var sql = @"INSERT INTO Product (ProductId, Brand, Name, Price)
//          VALUES (@ProductId, @Brand, @Name, @Price)";

//var prod = new Product { ProductId = 1000002, Brand = "His Brand", Name = "His Product", Price = 25.5 };
//conn.Execute(sql, prod);

//var sql = @"UPDATE Product
//            SET ImageLink=@Url
//            WHERE Name=@Name";
//conn.Execute(sql, new {Url="http://www.google.com/images", Name="His Product"});

//var sql = @"DELETE FROM Product WHERE Name = @Name";
//conn.Execute(sql, new { Name = "His Product" });

//var results = conn.Query<Product>("SELECT * FROM Product");
//foreach (var record in results)
//{
//    Console.WriteLine($"{record.Name}:{record.Price}:{record.ImageLink}");
//}

//HELPER/WRAPPER
//}


