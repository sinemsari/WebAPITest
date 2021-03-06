//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookAdviser.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public string Abstract { get; set; }
        public string LanguageID { get; set; }
        public Nullable<int> TranslatorID { get; set; }
        public Nullable<int> PublishYear { get; set; }
        public string ISBN { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Language Language { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Author Translator { get; set; }
    }
}
