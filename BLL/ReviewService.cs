using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BEL;

namespace BLL
{
    public class ReviewService
    {
        public static List<ReviewModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PReview, ReviewModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ReviewModel>>(DataAccessFactory.PReviewDataAccess().GetAll());
            return data;
        }




        public static void Delete(int id)
        {
            DataAccessFactory.PReviewDataAccess().Delete(id);
        }

        public static void Add(ReviewModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReviewModel, PReview>())).Map<PReview>(e);
            DataAccessFactory.PReviewDataAccess().ADD(data);
        }
        public static void Edit(ReviewModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReviewModel, PReview>())).Map<PReview>(e);
            DataAccessFactory.PReviewDataAccess().Edit(data);
        }
        public static ReviewModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PReview, ReviewModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ReviewModel>(DataAccessFactory.PReviewDataAccess().Get(id));
            return data;
        }
    }
}
