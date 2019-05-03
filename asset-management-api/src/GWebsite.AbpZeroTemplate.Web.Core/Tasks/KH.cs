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
using System.Data;

namespace QuartzWithCore.Tasks
{
    public class KH
    {
        /// <summary>
        /// Calculate Depreciation
        /// </summary>
        /// <param name="startDate">Start Date</param>
        /// <param name="endDate">End Start</param>
        /// <param name="originalPrice">Original Price</param>
        /// <returns>Depreciation</returns>
        public double calculateDepreciation(double originalPrice, int totalMonths = 0)
        {
            return totalMonths <= 1 ? originalPrice : originalPrice / totalMonths;
        }
        public void AddParameter(string query, object[] parameter, SqlCommand command)
        {
            if (parameter != null)
            {
                string[] listParameter = query.Split(' ');
                int i = 0;
                foreach (string item in listParameter)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        ++i;
                    }
                }
            }
        }
        public int Execute(AssetDto asset, object[] parameter = null)
        {
            if (DateTime.Now.Day != 25)
            {
                return 0;
            }
            int data = 0;
            string connectionStr = @"Data Source=DESKTOP-0TVNIA1;Initial Catalog=gwebsite;Integrated Security=True";
            string query = "UPDATE Assets SET DepreciationValue = " + calculateDepreciation(asset.OriginalPrice, asset.MonthDepreciation);
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                AddParameter(query, parameter, command);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
    }
}
