﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.CodeGenerator.Model
{
    public class GenerateDto
    {
        public string[] queryColumn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dbName { get; set; }
        /// <summary>
        /// 项目命名空间
        /// </summary>
        public string baseSpace { get; set; }
        /// <summary>
        /// 要生成代码的表
        /// </summary>
        public string tableName { get; set; }
        /// <summary>
        /// 要删除表名的字符串用
        /// </summary>
        public string replaceTableNameStr { get; set; }
        /// <summary>
        /// 要生成的文件
        /// </summary>
        public int[] genFiles { get; set; }
        public bool coverd { get; set; } = true;
    }
}