using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace Lab03_BAITAPTULAM_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrimeNumbers()
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return View(primes);
        }
        // Điều kiện số nguyên tố 
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }
            return true;
        }
        // Giai thừa từ 1 đến 10 
        public ActionResult Factorials()
        {
            Dictionary<int, long> factorials = new Dictionary<int, long>();
            for (int i = 1; i <= 10; i++)
            {
                factorials.Add(i, Factorial(i));
            }
            return View(factorials);
        }
        // Điều kiện để tính giai thừa 
        private long Factorial(int n)
        {
            if (n == 0) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        // Bảng cửu chương từ 2 đến 9 
        public ActionResult MultiplicationTable()
        {
            return View();
        }
    }
}