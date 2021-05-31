using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Entity_Framework_Core_and_ADO_.NET.Models.Entity
{
    /// <summary>
    /// - Có 2 cách xác lập quan hệ Giữa Entity
    /// Ex: Quan hệ 1 / n
    /// + Cách 1: Sử dụng Annotation [] Giống Required
    /// + Cách 2: Sử dụng Config trong DBContext
    /// </summary>
    public class Post
    {
        private int postID;
        private string postTitle;
        private string postContent;
        private string postDescription;
        private int viewCount;
        private int cateID;
        
        [Key]
        public int PostID { get => postID; set => postID = value; }

        [StringLength(255,ErrorMessage = "Invalid Type or Reach Limit")]
        public string PostTitle { get => postTitle; set => postTitle = value; }

        //Sử dụng kiểu nvarchar trong csdl
        [Column(TypeName = "nvarchar(MAX)")]
        public string PostContent { get => postContent; set => postContent = value; }

        [StringLength(400,ErrorMessage = "Invalid Type or Reach Limit")]
        public string PostDescription { get => postDescription; set => postDescription = value; }

        public int ViewCount { get => viewCount; set => viewCount = value; }

        //Set ForeignKey
        [ForeignKey("CateID")]
        public int CateID { get => cateID; set => cateID = value; }

        //Virtual cannot add getter ad setter
        public virtual Category Category { get; set; }
    }
}
