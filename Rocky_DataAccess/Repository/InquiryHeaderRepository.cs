using Microsoft.AspNetCore.Mvc.Rendering;
using Rocky_DataAccess.Repository.IRepository;
using Rocky_Models;
using Rocky_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky_DataAccess.Repository
{
    public class InquairyHeaderRepository : Repository<InquiryHeader>, IInquaryHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public InquairyHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(InquiryHeader obj)
        {
            _db.InquiryHeader.Update(obj);
        }
    }
}
