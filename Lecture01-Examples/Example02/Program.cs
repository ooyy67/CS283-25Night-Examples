﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementLibrary;

namespace example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "李家宏",
                phone = "0912345678",
                address = "台大資工"
            };
            Console.WriteLine("學生姓名:{0}, 電話:{1}, 住址:{2}"
                , aStudent.name
                , aStudent.phone
                , aStudent.address
            );
        }
    }
}