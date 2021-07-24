using static UrbanPlanner.Building;
using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building KeangnamHanoiLandmarkTower = new Building("Khu E6 Đô thị mới Cầu Giấy, Phạm Hùng, Mễ Trì, Nam Từ Liêm, Hà Nội, Vietnam");
            KeangnamHanoiLandmarkTower.Stories = 72;
            KeangnamHanoiLandmarkTower.Width = 368;
            KeangnamHanoiLandmarkTower.Depth = 125;
            KeangnamHanoiLandmarkTower.Construct();
            KeangnamHanoiLandmarkTower.Purchase("Keangnam Enterprises, Ltd.");
            KeangnamHanoiLandmarkTower.DisplayInfo();

            Building MakkahRoyalClockTower = new Building("الملاوي، Al Haram, Mecca 24231, Saudi Arabia");
            MakkahRoyalClockTower.Stories = 120;
            MakkahRoyalClockTower.Width = 557;
            MakkahRoyalClockTower.Depth = 557;
            MakkahRoyalClockTower.Construct();
            MakkahRoyalClockTower.Purchase("Saudi Binladin Group");
            MakkahRoyalClockTower.DisplayInfo();

            Building ChongqingWorldFinancialCenter = new Building("China, Chongqing, Yuzhong District, 民族路188号");
            ChongqingWorldFinancialCenter.Stories = 78;
            ChongqingWorldFinancialCenter.Width = 400;
            ChongqingWorldFinancialCenter.Depth = 511;
            ChongqingWorldFinancialCenter.Construct();
            ChongqingWorldFinancialCenter.Purchase("Chongqing Worthy Land Co., Ltd.");
            ChongqingWorldFinancialCenter.DisplayInfo();
        }
    }
}
