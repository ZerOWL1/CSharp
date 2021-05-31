using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Entity_Framework_Core_and_ADO_.NET.Models.Entity
{
    public class Category
    {
        //Sử dụng HashSet để add dữ liệu từ ICollection
        public Category()
        {
            posts = new HashSet<Post>();
        }

        private int id;
        private string categorieName;
        //Quan Hệ 1/n. 1 Cate có nhiều bài viết dùng ICollection
        private ICollection<Post> posts;

        [Key]
        public int ID { get => id; set => id = value; }
        
        [StringLength(50)]
        public string CategorieName { get => categorieName; set => categorieName = value; }
        public ICollection<Post> Posts { get => posts; set => posts = value; }

    }
}
