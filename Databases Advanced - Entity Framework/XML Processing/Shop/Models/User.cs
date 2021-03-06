﻿namespace Shop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Serializable()]
    public class User
    {
        public User()
        {
            this.ProductsSold = new HashSet<Product>();
            this.ProductsBought = new HashSet<Product>();
            this.Friends = new HashSet<UserFriend>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }


        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        [InverseProperty("Buyer")]
        public virtual ICollection<Product> ProductsSold { get; set; }

        [InverseProperty("Seller")]
        public virtual ICollection<Product> ProductsBought { get; set; }

        public virtual ICollection<UserFriend> Friends { get; set; }

    }

    public class UserDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }


        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public int Age { get; set; }

    }
}
