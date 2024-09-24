using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai1.Controllers
{
    public class GPTController : Controller
    {
        // GET: GPT
        public string giaipt2(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (a == 0) return "Phương trình vô nghiệm";
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Phương trình có hai nghiệm phân biệt:\nx1 = {x1:F2}\nx2 = {x2:F2}";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phương trình có nghiệm kép:\nx = {x:F2}";
            }
            else
            {
                return "Phương trình không có nghiệm thực";
            }
        }

    }
}