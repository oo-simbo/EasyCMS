//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models {

	//[JsonObject(MemberSerialization.OptIn)]
	public partial class expert_question {

        [Column(IsPrimary =true)]
        public string id { get; set; }
        /// <summary>
        /// 咨询标题
        /// </summary>
        public string qtitle { get; set; }
        /// <summary>
        /// 咨询内容
        /// </summary>
        public string qcontent { get; set; }
        /// <summary>
        /// 咨询人open_id
        /// </summary>
        public string insert_id { get; set; }
        /// <summary>
        /// 咨询时间
        /// </summary>
        public DateTime insert_time { get; set; }
        /// <summary>
        /// 专家 open_id
        /// </summary>
        public string expert_id { get; set; }
        /// <summary>
        /// 专家的后台数据id 一个Openid有可能绑定了多个专家信息，所以需要使用数据id来区分咨询的具体专家是哪一位
        /// </summary>
        [JsonProperty, Column(DbType = "char(24)")]
        public string expert_oid { get; set; } = string.Empty;
        public string expert_name { get; set; }
        /// <summary>
        /// 初次回复
        /// </summary>
        public string resp_content_one { get; set; }
        /// <summary>
        /// 追加回复
        /// </summary>
        public string resp_content_two { get; set; }
        /// <summary>
        /// 初次回复时间
        /// </summary>
        public DateTime resp_time_one { get; set; }
        /// <summary>
        /// 追加回复时间
        /// </summary>
        public DateTime resp_time_two { get; set; }
        /// <summary>
        /// 回复次数
        /// </summary>
        public int resp_times { get; set; }
        /// <summary>
        /// 父问题id
        /// </summary>
        public string pid { get; set; }
        /// <summary>
        /// 回合总次数
        /// </summary>
        public int total_times { get; set; }
        /// <summary>
        /// 当前回合标识
        /// </summary>
        public int round_num { get; set; }
        /// <summary>
        /// 是否结束
        /// </summary>
        public bool qend { get; set; }
        /// <summary>
        /// 是否打赏
        /// </summary>
        public bool qpay { get; set; }
        /// <summary>
        /// 打赏金额
        /// </summary>
        public int pay_money { get; set; }

        /// <summary>
        /// 诊单号
        /// </summary>
        public long question_no { get; set; }

        /// <summary>
        /// 当前问题评分
        /// </summary>
        public int star_num { get; set; }

        /// <summary>
        /// 回合是否结束
        /// </summary>
        public bool round_end { get; set; }

        /// <summary>
        /// 回合最新追问时间
        /// </summary>
        public DateTime last_time { get; set; }

        /// <summary>
        /// 总的咨询次数
        /// </summary>
        public int serial_num { get; set; }

        public bool high_light { get; set; }
        /// <summary>
        /// 高危行为事件
        /// </summary>
        public DateTime highrisk_time { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string provice { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string city { get; set; }

        ///// <summary>
        ///// 分享标题
        ///// </summary>
        //public string share_title { get; set; }
        ///// <summary>
        ///// 0-不分享，1-分享，2-同意，3-拒绝
        ///// </summary>
        //public int share_status { get; set; }
        ///// <summary>
        ///// 分享分类
        ///// </summary>
        //public int share_category { get; set; }

        /// <summary>
        /// 0-未删除，1-已删除
        /// </summary>
        public int is_delete { get; set; }
        /// <summary>
        /// 性取向 0-同性，1-异性，2-其他
        /// </summary>
        public int sexual_orientation { get; set; }

        /// <summary>
        /// 最近一次推送时间
        /// </summary>
        public DateTime last_push_time { get; set; }

        /// <summary>
        /// 精分评价
        /// </summary>
        public string admin_remark { get; set; }
        /// <summary>
        /// 患者评价
        /// </summary>
        public string patient_remark { get; set; }

        /// <summary>
        /// 是否有评价
        /// </summary>
        public int has_patient_remark { get; set; }
        /// <summary>
        /// 患者评价时间
        /// </summary>
        public DateTime comment_time { get; set; }
        /// <summary>
        /// 是否匿名
        /// </summary>
        public int is_anonymous { get; set; }
    }

}