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
        public void GetAllRecordsByRatingAndId(List<ProductReview> productreviewList)
        {
            var recordeData = ((from productReview in productreviewList
                                where (productReview.ProductID == 1 && productReview.Rating >3 ) || 
                                (productReview.ProductID == 4 && productReview.Rating > 3) ||
                                (productReview.ProductID == 4 && productReview.Rating > 3)
                                select productReview
                                ));
            foreach (var list in recordeData)
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                  $" UserID    : {list.UserID}\n" +
                                  $" Rating    : {list.Rating}\n" +
                                  $" Review    : {list.Review}\n" +
                                  $" isLike    : {list.IsLike}\n");
            }
        }
        public void RetriveCountOfRecords(List<ProductReview> productreviewList)
        {
            var recordeData = productreviewList.GroupBy(x=>x.ProductID).Select(x=>new { ProductID = x.Key,Count  =x.Count()});
            foreach (var list in recordeData)
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                  $" Count   : {list.Count}\n" );
            }
        }
        public void ProductIDReview(List<ProductReview> productreviewList)
        {
            var recordeData = (from list in productreviewList select new { list.ProductID, list.Review });
            foreach (var list in recordeData)
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                  $" Review  : {list.Review}\n");
            }
        }
        public void SkipTopFive(List<ProductReview> productreviewList)
        {
            var recordeData = (from list in productreviewList orderby list.Rating descending select list);
            foreach (var list in recordeData.Skip(5))
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                   $" UserID    : {list.UserID}\n" +
                                   $" Rating    : {list.Rating}\n" +
                                   $" Review    : {list.Review}\n" +
                                   $" isLike    : {list.IsLike}\n");
            }
        }
        public void GetAllRecordsWhereMessageNice(List<ProductReview> productreviewList)
        {
            var recordeData = ((from productReview in productreviewList
                                where (productReview.Review == "Nice")
                                select productReview
                                ));
            foreach (var list in recordeData)
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                  $" UserID    : {list.UserID}\n" +
                                  $" Rating    : {list.Rating}\n" +
                                  $" Review    : {list.Review}\n" +
                                  $" isLike    : {list.IsLike}\n");
            }
        }
        public void RetriveDataWhereId10(List<ProductReview> productreviewList)
        {
            var recordeData = ((from productReview in productreviewList
                                where (productReview.ProductID == 10)
                                select productReview
                              ));
            foreach (var list in recordeData)
            {
                Console.WriteLine($" ProductID : {list.ProductID}\n" +
                                  $" UserID    : {list.UserID}\n" +
                                  $" Rating    : {list.Rating}\n" +
                                  $" Review    : {list.Review}\n" +
                                  $" isLike    : {list.IsLike}\n");
            }
        }
    }
}