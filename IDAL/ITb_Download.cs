using System;
using System.Data;
namespace Maticsoft.IDAL
{
	/// <summary>
	/// �ӿڲ�ITb_Download 
	/// </summary>
	public interface ITb_Download
	{
		#region  ��Ա����
		/// <summary>
		/// �õ����ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(int ID);
		/// <summary>
		/// ����һ������
		/// </summary>
		int Add(Maticsoft.Model.Tb_Download model);
		/// <summary>
		/// ����һ������
		/// </summary>
		bool Update(Maticsoft.Model.Tb_Download model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		bool Delete(int ID);
		bool DeleteList(string IDlist );
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		Maticsoft.Model.Tb_Download GetModel(int ID);
		/// <summary>
		/// ��������б�
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		/// <summary>
		/// ���ݷ�ҳ��������б�
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  ��Ա����
	}
}
