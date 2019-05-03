using Quartz;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using GWebsite.AbpZeroTemplate.Application.Share.Assets;
using GWebsite.AbpZeroTemplate.Application.Share.Assets.Dto;
using System.Linq;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace QuartzWithCore.Tasks
{
    public class KH : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Run");
            //IEnumerable<AssetForViewDto> assets = null;
            //Console.WriteLine("Run");
            //SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            //csb.DataSource = "DESKTOP-OAVL1J3";
            //csb.InitialCatalog = "gwebsite3";
            //csb.IntegratedSecurity = true;

            //string connString = "Data Source=DESKTOP-OAVL1J3;Initial Catalog=gwebsite3;Integrated Security=True";

            ////Be sure to replace <YourTable> with the actual name of the Table
            //string queryString = "select * from Assets";
            //var map = new Dictionary<int, float>();
            //using (SqlConnection connection = new SqlConnection(connString))
            //using (SqlCommand command = connection.CreateCommand())
            //{
            //    command.CommandText = queryString;

            //    connection.Open();

            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            int id = int.Parse(reader["Id"].ToString());
            //            float K = (float)11 / 12;
            //            float KH = int.Parse(reader["Originalprice"].ToString()) * K;
            //            map.Add(id, KH);

            //        }
            //    }
            //}
            //foreach (KeyValuePair<int, float> asset in map)
            //{
            //    try
            //    {
            //        using (SqlConnection connection = new SqlConnection(connString))
            //        using (SqlCommand command = connection.CreateCommand())
            //        {
            //            command.CommandText = "UPDATE Assets SET Originalprice = " + asset.Value.ToString() + " WHERE Id = " + asset.Key.ToString();
            //            Console.WriteLine(command.CommandText);
            //            connection.Open();
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {


            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex);
            //    }
            //}
            return Task.FromResult(0);
        }
    }
}
