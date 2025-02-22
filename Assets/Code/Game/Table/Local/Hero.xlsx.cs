
//------------------------------------------------------------------------------
// <auto-generated>
//    Genera by BDFramework
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game.Data.Local
{
    using System;
    using System.Collections.Generic;
    using SQLite4Unity3d;
    
    [Serializable()]
    public class Hero
    {
        
        /// <summary>
        /// id
        /// </summary>
        [PrimaryKey]
        public int Id {get;set;}
        /// <summary>
        /// 名称
        /// </summary>
        public string Name {get;set;}
        /// <summary>
        /// 级别
        /// </summary>
        public string Level {get;set;}
        /// <summary>
        /// 星级
        /// </summary>
        public int StarLevel {get;set;}
        /// <summary>
        /// 下个等级
        /// </summary>
        public int NextLevel {get;set;}
        /// <summary>
        /// 属性名
        /// </summary>
        public string[] AttributeName {get;set;}
        /// <summary>
        /// 属性值
        /// </summary>
        public int[] AttributeValue {get;set;}
        /// <summary>
        /// 拥有技能id
        /// </summary>
        public int[] Skills {get;set;}
    }
}