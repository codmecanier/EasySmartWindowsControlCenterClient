using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using 智能平台总控端.Models;
using EntityFramework.Extensions;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
namespace 智能平台总控端.Service
{
    public class SqlDao<T> where T : class
    {
        protected static EasySmartDataBaseContext context{get;private set;}
        private static DbSet<T> db;
        public SqlDao()
        {
            context = new EasySmartDataBaseContext();
            db = context.Set<T>();
        }
        /// <summary>
        /// 增加多个数据
        /// </summary>
        /// <param name="modelList"></param>
        public void AddList(List<T> modelList)
        {
            foreach (var obj in modelList)
            {
                db.Add(obj);
            }
            this.SaveChanges();
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            db.Add(entity);
           this.SaveChanges();
        }
        /// <summary>  
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        public virtual bool Update(T entity)
        {
            db.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
        /// <summary>
        /// 修改多条语句
        /// </summary>
        /// <param name="entities"></param>
        public virtual bool UpdateList(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                db.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
            }
            this.SaveChanges();
            return true;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// 】
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            db.Remove(entity);
            this.SaveChanges();
        }
        public void Delete(Expression<Func<T,bool>> where)
        {
            db.Where(where).Delete();
            this.SaveChanges();
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return db;
        }
        /// <summary>
        /// 根据条件查找数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetByCondition(Expression<Func<T, bool>> where)
        {
            return db.Where(where);
        }
        /// <summary>
        /// 获取第一个满足条件的对象
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T GetByFirstOrDefault(Expression<Func<T, bool>> where)
        {
            return db.FirstOrDefault(where);
        }
        /// <summary>
        ///保存数据库
        /// </summary>
        public void SaveChanges()
        {
            //try
            //{
            context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var eve in dbEx.EntityValidationErrors)
            //    {
            //        eve.ValidationErrors.ToList().ForEach(p =>
            //        {
            //            Console.WriteLine(p.ErrorMessage);
            //        });
            //    }
            //}
            //catch (DbUpdateException ex)
            //{
            //}
        }
    }
}
