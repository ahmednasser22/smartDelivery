//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartDelivery.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Offers = new HashSet<Offer>();
            this.Orders = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        [Display(Name = "Fisrtname")]
        [Required(ErrorMessage = "First name is requierd.")]
        [MaxLength(50, ErrorMessage = "Firstname length must be with a maximum length of '50'.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter a valid Name.")]
        public string FirstName { get; set; }

        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "Last name is requierd.")]
        [MaxLength(50, ErrorMessage = "Lastname length must be with a maximum length of '50'.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter a valid name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is requierd.")]
        [MaxLength(50, ErrorMessage = "Email length must be with a maximum length of '50'.")]
        //  [RegularExpression(@"^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Please enter a valid email.")]
        //ahmedsayed added next line(42) in 19/6 2:38 AM
        [RegularExpression(@"^([A-Za-z-_\.]+)([0-9])?@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is requierd.")]
        [MaxLength(50, ErrorMessage = "Phone Length Must be with a maximum length of '50'.")]
        //ahmedsayed coment line(48) & added line(49) in 19/6 2:38 AM
        //[RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid phone number.")]
        [RegularExpression(@"^(01)(0|1|2|5)[0-9]{8}$", ErrorMessage = "Please enter a valid phone number must be 11 numbers from Vodafone,Orange,Etisalat or We.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is Requierd.")]
       
        [RegularExpression(@"^[A-Za-z0-9]+[_\-' A-Za-z0-9]+$", ErrorMessage = "Please enter a valid address.")]
        public string Address { get; set; }
        public byte[] Photo { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is requierd.")]
        [MaxLength(50, ErrorMessage = "Username length must be with a maximum length of '50'.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Please enter a valid Username.")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is requierd.")]
        [MaxLength(50, ErrorMessage = "Password length must be with a maximum length of '50'.")]
      //  [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Please enter a valid Password.")]
        public string PassWord { get; set; }

        public int Authorized { get; set; }
        public int Active { get; set; }
        [Display(Name = "Account Type")]
        [Required(ErrorMessage = "Account Type is requierd.")]
        public Nullable<int> CustomerType { get; set; }

        [Display(Name = "Shop Name")]
        [MaxLength(50, ErrorMessage = "Shopname length must be with a maximum length of '50'.")]
        [RegularExpression(@"^[A-Za-z0-9]+[_\-' A-Za-z0-9]+$", ErrorMessage = "Please enter a Name (should include charachter or numbers).")]
        public string ShopName { get; set; }
        public virtual UserType UserType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
