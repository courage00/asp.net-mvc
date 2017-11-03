//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCBASE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Employees1 = new HashSet<Employees>();
        }
    
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "請輸入姓名")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "請輸入職務")]
        public string Title { get; set; }

        [Required(ErrorMessage = "請輸入TitleOfCourtesy")]
        public string TitleOfCourtesy { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Required(ErrorMessage = "請輸入BirthDate")]     
        public Nullable<System.DateTime> BirthDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Required(ErrorMessage = "請輸入HireDate")]
        public Nullable<System.DateTime> HireDate { get; set; }

        [Required(ErrorMessage = "請輸入地址")]
        public string Address { get; set; }

        [Required(ErrorMessage = "請輸入HomePhone")]
        public string HomePhone { get; set; }

        [Required(ErrorMessage = "請輸入Extension")]
        public string Extension { get; set; }

       // [Required(ErrorMessage = "請輸入PhotoPath")]
        public string PhotoPath { get; set; }

        [Required(ErrorMessage = "請輸入Notes")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "請輸入ManagerID")]
        public Nullable<int> ManagerID { get; set; }

        [Required(ErrorMessage = "請輸入 Salary")]
        public Nullable<int> Salary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees1 { get; set; }
        public virtual Employees Employees2 { get; set; }
    }
}
