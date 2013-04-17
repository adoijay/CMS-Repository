using System;
using System.Data;
namespace Maticsoft.IDAL {
	/// <summary>
	/// 接口层Tb_UserNewsClass
	/// </summary>
	public interface ITb_UserNewsClass
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int  Add(Maticsoft.Model.Tb_UserNewsClass model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Maticsoft.Model.Tb_UserNewsClass model);
		/// <summary>
		/// 删除数据
		/// </summary>
		bool Delete(int id);
				bool DeleteList(string idlist );
				/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Maticsoft.Model.Tb_UserNewsClass GetModel(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
	} 
}