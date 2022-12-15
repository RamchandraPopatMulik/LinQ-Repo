using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Linqe
{
    public class Management
    {
        public readonly DataTable datatable = new DataTable();
        public void ToGetTopThreeRecords(List<ProductReview> productreviewList)
        {
            var recordeData = ((from productReview in productreviewList
                               orderby productReview.Rating descending
                               select productReview).Take(3));
            foreach (var list in recordeData)
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                  $" UserID    : {list.UserID}\n" +
                                  $" Rating    : {list.Rating}\n" +
                                  $" Review    : {list.Review}\n" +
                                  $" isLike    : {list.IsLike}\n");
            }
        }
        //public void GetAllRecordsByRatingAndId(List<ProductReview> productreviewList)
        //{
        //    var recordeData = ((from productReview in productreviewList where 
        //                        ));
        //    Console.WriteLine(recordeData);
        //}
    }
}