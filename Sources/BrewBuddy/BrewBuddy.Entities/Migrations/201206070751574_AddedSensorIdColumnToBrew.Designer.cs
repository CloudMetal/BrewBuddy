// <auto-generated />
namespace BrewBuddy.Entities.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class AddedSensorIdColumnToBrew : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201206070751574_AddedSensorIdColumnToBrew"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/soyd1fvVkPZtdj08JRlvkzUfpcVlkhMnrvDx/T7R2HgKtj2yH1CWDvX5zvcq5288++qrJ65d1dV6Uud+Qmv5e+XXwAX1EDVd53V6/ys/19bPZR+nd8L273Rfta947wIB+W7b39j5KX6zLMpuU9MF5Vjb5R+nq00ev26rOP8+XeZ21+exl1rZ5vcS7OY9AKfFo9entiPHw7s4eiHE3Wy6rNmtponuId9AEZfCbQfZ1WxPffJQ+K97ls+f58qKdW4S/yN6ZT/bu3/8o/WpZEJvRS229zv0Byt+bOz5dZEX5Q+/152Soz6upzsUPueOz5XlVL75O3/s7Ozvv1fnju07oNoriq3xarH4khT8EKdT2m3t+U7Tlz0G3T/NmWherHwZnxsTios5nBc1u83PReUPNphj5z0Xvzcv1pCympucnVVXm2fK95+951rRk6IvzIrcS9pSk500BJt4I7NaaAm7Cj/REgKYoz5uR/ZG2Cbo9tgT++SlyfWCviRzr5iezEvh/CC+9zpdNVTuOvCVdv4Zv8yK7LC54EqNC8VH6Ki9ljufFSiKJMVTI72++f1ZXi1cV4Hsf//6vq3U9BRGq/ndvsvoib2+nvo6bppoWjICnv0zn4VBOl7N0AyZCSIM/0W1dtsWKWIi6/eyjb/UoEwdn"
                       + "kPfAGUqEAHdD7Ajgl8uneZm3eXrMduqzj06yZprN+nNCtJiFn5Aazmvow6ykkJBMXVYs277OLpaESVYOo9155ZaKHihZ4N1vnuarfAldPUz72/TqdHC/b9tFh0w3UeXxXY99+kaR3mnpjbw2sZOGzfg8f9chlr7zOm89da/BL6k/x73KFH5s3OesEJSMPQbFsNYNAEDz2OvC6J2XPZqEEKxIey0iEt+dns1iZ1G1WPbmd7OgeQAsnbryEg4polbsVNvvHt+VDIp+8PjuQKrl8RfZakW610u96Cfpa8m7nGy/fv/cykJg3J02kRSLxdb2RC5SdpF3vqWuCdNnRd20ZLGySQZrcDJb9JrdkrFNbxH+7k+Z4TTzEn53rBTmoQJh6CsDBfGMhriAHmGH0Jv2jW+nSIVlZVZ3zBc0yUlVrhfLYa02/Lbz5XwY7tPbQ9KEjA9GP7o9jD4m74uFy5X4UNynt4cUJD8CAvtf9OE9vtuZ5p6W7/FUR8i7fHorLjYq4wMZOK76bsG7Qy/+v51tNaTwwehHt4cRZCN8SMEXt4cXJBhC1vO+eB94fs7ABxh+8x4QbVASQLOf3h5SGJYEQht88/8aQRPj/oFi1s9NMJSbhCz+2s+OiDk/1Ycx7L0OQ/p/l7AGwbwPKfji9vD+3yAKQxCDMN0HGHzxHvBstB4As5/+kIW05/R2m9je9RP7t3V61eH84sZFx54HKk0+SolEl8UM3ufr66bNF2M0GL/+ReVJCUXtGnyRLYvzvGnfVG9zLKCSg/z11y1t8q9pZuX/ixcvC1DgxsTneyaNugnI5WVWT+dZ3U8RvV+qLVhT/KaA/mwg2l0R/NpwN/m8G0BLWvP/0+t5/69hzFsBViv3DUONrKJ9zemOULq/SPYNwu6vgX1zwDv59knRvjdhY7n2GbFYW9yYa7+14PzcLG/9rIhNd1mKO3lPGP8fE73IktL/Xzi4DyyyWvR1pri7VnSbybi9Zfp6CzAmkywY"
                       + "/bBWScJE8tdY8vlayyyDuaHbKBmM472WVm7Vz/8LFlP6qenuXGn84ikq447fsJoiIQYJ3qSiORaGDldjOtPa7cuwYq8b80Wsh6HFhy5w4bQeaPk4Bji6LPKzuEoTjt7PUva5pStR3jvRtaVvZCWmH3wSd66X0LHyFzloxYUD8ZhgLvNpwJe2DXx3IyAdjEyTjj79Im8z0unZcd0W59m0pa+nedPw+jsra0REk3x2tvxy3a7WLQ05X0zKa58YELNN/fNyU4jz4y/Z4/Si7a8/BEKzgFn6cvlkXZQzi/eziGM1AALyq74M5rKFT3NxbSG9qJa3BKTke2rUzpt8sSoJWPPl8nV2mQ/jdjMNQ4o9flpkF3W2aBSGe5/+JPabLd4d/T8BAAD//9BhEeHZLQAA"; }
        }
    }
}
