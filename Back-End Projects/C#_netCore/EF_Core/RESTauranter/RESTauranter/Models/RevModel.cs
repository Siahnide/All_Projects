using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RESTauranter.Models;

namespace RESTauranter.Models
{

    public class RevModel
    {
        public IEnumerable<Review> reviews {get;set;}
    }

}