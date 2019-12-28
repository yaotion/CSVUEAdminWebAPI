using CS.Img.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Img.RetailType
{
    /// <summary>
    /// 储值赠送信息Repository实现
    /// </summary>
    public class RetailTypeRepository : CSRepository, IRetailTypeRepository
    {
        /// <summary>
        /// 构造 函数
        /// </summary>
        /// <param name="context"></param>
        public RetailTypeRepository(CSDBContext context)
            : base(context)
        { }
        /// <summary>
        /// 获取散户类型列表
        /// </summary>
        /// <returns></returns>
        public List<RetailType> GetRetailTypeList()
        {
            string strSql = @"select * from UserCardRetailType  order by RetailTypeID";
            string strWhere = "";
           
            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
               
            };
            return DBContext.Query<RetailType>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 添加散户类型
        /// </summary>
        /// <param name="retailType"></param>
        public void AddRetailType(RetailType retailType)
        {
            string strSql = @"insert into UserCardRetailType  (RetailTypeID,RetailTypeName) values (@RetailTypeID,@RetailTypeName)";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                retailType.RetailTypeID,
                retailType.RetailTypeName
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 修改散户类型
        /// </summary>
        /// <param name="retailType"></param>
        public void UpdateRetailType(RetailType retailType)
        {
            string strSql = @"update UserCardRetailType  set RetailTypeName = @RetailTypeName where RetailTypeID = @RetailTypeID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                retailType.RetailTypeID,
                retailType.RetailTypeName
            };
            DBContext.Execute(strSql, sqlParams);
        }
        /// <summary>
        /// 删除散户类型
        /// </summary>
        /// <param name="retailTypeID"></param>
        public void DeleteRetailType(int retailTypeID)
        {
            string strSql = @"delete from UserCardRetailType where RetailTypeID = @RetailTypeID";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                retailTypeID
            };
            DBContext.Execute(strSql, sqlParams);
        }

        /// <summary>
        /// 获取指定散户类型的卡信息
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <returns></returns>
        public List<RetailTypeCard> GetRetailTypeCardList(int retailTypeID)
        {
            string strSql = @"select CardNo,HolderName,Mobile,u.RetailTypeID,t.RetailTypeName from UserCardInfo u 
                Left Join UserCardRetailType t on u.RetailTypeID=t.RetailTypeID  where u.RetailTypeID = @RetailTypeID  order by u.CardNo";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                RetailTypeID = retailTypeID
            };
            return DBContext.Query<RetailTypeCard>(strSql, sqlParams).ToList();
        }
        /// <summary>
        /// 修改散户卡的级别
        /// </summary>
        /// <param name="retailTypeID"></param>
        /// <param name="cardNo"></param>
        public void UpdateCardRetailType(int retailTypeID, string cardNo)
        {
            string strSql = @"update UserCardInfo set RetailTypeID = @RetailTypeID where CardNo=@CardNo";
            string strWhere = "";

            strSql = string.Format(strSql, strWhere);
            var sqlParams = new
            {
                RetailTypeID = retailTypeID,
                CardNo = cardNo
            };
            DBContext.Execute(strSql, sqlParams);
        }
    }
}
