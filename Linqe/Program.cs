using System.Collections.Generic;
using System.Linq;
namespace Linqe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<ProductReview> productreviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=2,UserID=2,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProductID=3,UserID=3,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=4,UserID=4,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=5,UserID=5,Rating=3,Review="Bad",IsLike=true},
                new ProductReview(){ProductID=6,UserID=6,Rating=2,Review="Bad",IsLike=true},
                new ProductReview(){ProductID=7,UserID=7,Rating=5,Review="Good",IsLike=true},
            };
            foreach(var List in productreviewList)
            {
                Console.WriteLine("Product Id: "+List.ProductID+"UserID : "+List.UserID+"Rating :"+List.Rating+"Review :"+List.Review+"IsLike :"+List.IsLike);
            }

            Management management = new Management();
            management.ToGetTopThreeRecords(productreviewList);

        }
    }
}