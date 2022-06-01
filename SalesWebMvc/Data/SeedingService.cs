using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Fashion");
            Department d3 = new Department(3, "Eletronics");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com.br", new DateTime(1998, 4, 22), 2000.0, d1);
            Seller s2 = new Seller(2, "Angelina Jolie", "jolie@gmail.com.br", new DateTime(1988, 7, 02), 5000.0, d2);
            Seller s3 = new Seller(3, "Arnold Jim", "jim@gmail.com.br", new DateTime(1976, 8, 21), 4000.0, d3);
            Seller s4 = new Seller(4, "Alex Blue", "alex@gmail.com.br", new DateTime(1997, 11, 13), 5000.0, d4);
            Seller s5 = new Seller(5, "Mirthes Pink", "mi@gmail.com.br", new DateTime(1974, 10, 21), 3000.0, d1);
            Seller s6 = new Seller(6, "Kathy Honda", "honda@gmail.com.br", new DateTime(1969, 12, 01), 2000.0, d3);
            Seller s7 = new Seller(7, "Athos Black", "black@gmail.com.br", new DateTime(1990, 11, 04), 6000.0, d4);
            Seller s8 = new Seller(8, "Mayke Sam", "mayke@gmail.com.br", new DateTime(1998, 07, 11), 3000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 08, 22), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2016, 07, 21), 18000.0, SaleStatus.Pending, s8);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 07, 01), 19000.0, SaleStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2017, 08, 10), 20000.0, SaleStatus.Billed, s5);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 12, 22), 21000.0, SaleStatus.Canceled, s7);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2017, 04, 17), 18000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 08, 20), 19000.0, SaleStatus.Billed, s8);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 02, 28), 2000.0, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 01, 27), 22000.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2017, 08, 19), 19000.0, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 08, 22), 12000.0, SaleStatus.Pending, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2016, 07, 21), 18000.0, SaleStatus.Pending, s8);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 07, 01), 19000.0, SaleStatus.Pending, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2017, 08, 10), 20000.0, SaleStatus.Canceled, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 12, 22), 21000.0, SaleStatus.Canceled, s7);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 01, 18), 18000.0, SaleStatus.Billed, s1);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2020, 08, 20), 19000.0, SaleStatus.Billed, s8);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 02, 25), 32000.0, SaleStatus.Pending, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2016, 03, 27), 22000.0, SaleStatus.Billed, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2017, 05, 19), 19000.0, SaleStatus.Canceled, s1);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2017, 08, 11), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2016, 07, 21), 18000.0, SaleStatus.Pending, s8);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 09, 01), 19000.0, SaleStatus.Pending, s3);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2017, 08, 11), 20000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 12, 22), 21000.0, SaleStatus.Canceled, s7);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2017, 05, 15), 18000.0, SaleStatus.Billed, s1);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2020, 08, 21), 19000.0, SaleStatus.Billed, s8);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2022, 11, 29), 32000.0, SaleStatus.Pending, s2);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2017, 01, 27), 22000.0, SaleStatus.Billed, s3);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 12, 11), 19000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
