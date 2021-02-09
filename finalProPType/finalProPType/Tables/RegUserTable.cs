using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace finalProPType.Tables
{
    class RegUserTable
    {
        [PrimaryKey,AutoIncrement]
        public int UserID { get; set; }
        [MaxLength(20)]
        public string UserName { get; set; }
        [MaxLength(25)]
        public string password { get; set; }
        [MaxLength(25)]
        public string confirmPw { get; set; }
        [MaxLength(10)]
        public string phoneNumber { get; set; }
    }
}
