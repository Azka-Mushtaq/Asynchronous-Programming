using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asnychronous_Programming.Controllers
{
    public class ProductController : Controller
    {
        // Synchronous method to process product tasks
        public ActionResult ProcessProductTasks()
        {
            var watch = new Stopwatch();
            watch.Start();

            var validation = ValidateProduct();
            var pricing = CalculatePrice();
            var description = GenerateDescription();
            var discount = ApplyDiscount();
            var inventory =  CheckInventory();
            var shipping =  PrepareForShipping();

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;

            ViewBag.Validation = validation;
            ViewBag.Pricing = pricing;
            ViewBag.Description = description;
            ViewBag.Discount = discount;
            ViewBag.Inventory = inventory;
            ViewBag.Shipping = shipping;

            return View();
        }

        // Asynchronous method to process product tasks
        public async Task<ActionResult> AsyncProcessProductTasks()
        {
            var watch = new Stopwatch();
            watch.Start();

            var validationTask = ValidateProductAsync();
            var pricingTask = CalculatePriceAsync();
            var descriptionTask = GenerateDescriptionAsync();
            var discountTask = ApplyDiscountAsync();
            var inventoryTask = CheckInventoryAsync();
            var shippingTask = PrepareForShippingAsync();

            var validation = await validationTask;
            var pricing = await pricingTask;
            var description = await descriptionTask;
            var discount = await discountTask;
            var inventory = await inventoryTask;
            var shipping = await shippingTask;

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;

            ViewBag.Validation = validation;
            ViewBag.Pricing = pricing;
            ViewBag.Description = description;
            ViewBag.Discount = discount;
            ViewBag.Inventory = inventory;
            ViewBag.Shipping = shipping;

            return View();
        }

     

        // Simulating synchronous product tasks
        private string ValidateProduct()
        {
            var start = DateTime.Now;
            Thread.Sleep(4000); // Simulate validation time (4 seconds)
            var end = DateTime.Now;
            return $"Validating Product Details. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Product validation completed";
        }

        private string CalculatePrice()
        {
            var start = DateTime.Now;
            Thread.Sleep(3000); // Simulate price calculation time (3 seconds)
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Calculating Price. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}.Price calculation completed";
        }

        private string GenerateDescription()
        {
            var start = DateTime.Now;
            Thread.Sleep(1500); // Simulate description generation time (1.5 seconds)
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Generating product description. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}.Product description generated";
        }

        private string ApplyDiscount()
        {
            var start = DateTime.Now;
            Thread.Sleep(1000); // Simulate discount application time (1 second)
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Applying Discount. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Discount applied";
        }

        private string CheckInventory()
        {
            var start = DateTime.Now;
            Thread.Sleep(2500); // Simulate inventory check time (2.5 seconds)
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Checking Inventory status. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Inventory status checked";

        }

        private string PrepareForShipping()
        {
            var start = DateTime.Now;
            Thread.Sleep(2000); // Simulate shipping preparation time (2 seconds)
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Preparing Product for Shipping. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Product prepared for shipping";
          
        }

        // Simulating asynchronous product tasks
        private async Task<string> ValidateProductAsync()
        {
            
            var start = DateTime.Now;
            await Task.Delay(4000); // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Validating Product Details. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Product validation completed";
           
        }

        private async Task<string> CalculatePriceAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(3000); // Simulate price calculation time asynchronously
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Calculating Price. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}.Price calculation completed";
        }

        private async Task<string> GenerateDescriptionAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(1500); // Simulate description generation time asynchronously
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Generating product description. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}.Product description generated";
        }

        private async Task<string> ApplyDiscountAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(1000); // Simulate discount application time asynchronously
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Applying Discount. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Discount applied";
        }

        private async Task<string> CheckInventoryAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(2500); // Simulate inventory check time asynchronously
            // Simulate validation time asynchronously
            var end = DateTime.Now;
            return $"Checking Inventory status. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Inventory status checked";
        }

        private async Task<string> PrepareForShippingAsync()
        {

            var start = DateTime.Now;
            await Task.Delay(2000); // Simulate shipping preparation time asynchronously
            
            var end = DateTime.Now;
            return $"Preparing Product for Shipping. started at {start:HH:mm:ss} and ended at {end:HH:mm:ss}. Product prepared for shipping";

        }
    }
}
