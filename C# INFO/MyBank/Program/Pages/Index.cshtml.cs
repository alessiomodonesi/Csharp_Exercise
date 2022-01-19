﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programCc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void Login()
        {
            string emailUtente = "pippo@gmail.com";
            string pwUtente = "12345678";

            string email = Console.ReadLine();
            string pw = Console.ReadLine();

            if (email != emailUtente || pw != pwUtente)
                Console.WriteLine("Credenziali errate");
            else
                Console.WriteLine("Login effettuato");
        }
    }
}
