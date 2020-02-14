﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using DataAccess.Config;

namespace DataAccess.Assorting
{
    /// <summary>
    /// 单托拣选结果。
    /// </summary>
    public class AST_PalletResult
    {
        /// <summary>
        /// 初始化单托拣选结果。
        /// </summary>
        public AST_PalletResult()
        {
            this.AST_PalletResultItems = new HashSet<AST_PalletResultItem>();
        }

        /// <summary>
        /// 获取或设置自增主键。
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 获取或设置项目编号。
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 获取或设置 WBS 编号。
        /// </summary>
        [MaxLength(100)]
        public string WbsId { get; set; }

        /// <summary>
        /// 获取或设置项目阶段。
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ProjectStep { get; set; }

        /// <summary>
        /// 获取或设置配送批次。
        /// </summary>
        [Index]
        [Required]
        [MaxLength(100)]
        public string BatchCode { get; set; }

        /// <summary>
        /// 获取或设置分拣巷道的外键。
        /// </summary>
        public int CFG_ChannelId { get; set; }

        /// <summary>
        /// 获取或设置托盘的外键。
        /// </summary>
        public int CFG_PalletId { get; set; }

        /// <summary>
        /// 获取或设置开始拣选时间。
        /// </summary>
        public DateTime BeginPickTime { get; set; }

        /// <summary>
        /// 获取或设置最后拣选时间。
        /// </summary>
        [Index]
        public DateTime EndPickTime { get; set; }

        /// <summary>
        /// 获取或设置操作员的外键。
        /// </summary>
        public int? CFG_EmployeeId { get; set; }

        /// <summary>
        /// 获取或设置分拣巷道。
        /// </summary>
        public virtual CFG_Channel CFG_Channel { get; set; }

        /// <summary>
        /// 获取或设置托盘。
        /// </summary>
        public virtual CFG_Pallet CFG_Pallet { get; set; }

        /// <summary>
        /// 获取或设置操作员。
        /// </summary>
        public virtual CFG_Employee CFG_Employee { get; set; }

        /// <summary>
        /// 获取或设置关联的通讯消息。
        /// </summary>
        public virtual AST_PalletResultMessage AST_PalletResultMessage { get; set; }

        /// <summary>
        /// 获取明细的集合。
        /// </summary>
        [SoapIgnore]
        [XmlIgnore]
        public virtual ICollection<AST_PalletResultItem> AST_PalletResultItems { get; set; }
    }
}