using System.Collections.Generic;
using System.Linq;

namespace ortho48.OrthoRepository.PatientDirect.Core.Products
{
    public class ProductsProcess
    {
        private static readonly List<Product> AllProducts = new List<Product>()
        {
            new Product { ProductId=121,Name="4Sight",ImageUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7",MainCategories="Specialty Applications", AllCategories="Specialty Applications|Antioxidant Support|Eye Health|Ginkgo biloba Leaf Extract |Lipoic Acid|Lutein|Lycopene|N-Acetyl-L-Cysteine USP|Quercetin|Taurine|Zeaxanthin|Zinc |Capsule |InStock",
                Hidden =true,SortPrice=5.25m, SortSize=90, SizePriceList = new List<string>() { "90 CT: $5.25","120 CT: $4.25"}
            },
            new Product { ProductId=137,Name="Alpha Base Capsules w/ Iron",ImageUrl="https://preprod.orthopacks.com/images/default-source/products/151240.tmb-thumb190.png?Culture=en&sfvrsn=9f536c33_7",MainCategories="Essential Vitamins|Essential Health", AllCategories="Essential Vitamins|Essential Health|General Wellness|Multivitamins|Boron |Choline|Chromium |Copper |Folic Acid|Inositol|Iodine |Iron|Lipoic Acid|Lutein|Lycopene|Magnesium|Manganese |Mixed Tocopherols|Molybdenum |Niacin |Pantothenic Acid |Potassium|Riboflavin |Rutin|Selenium  |Thiamine |Vanadyl Sulfate|Vitamin A |Vitamin B12 |Vitamin B6 |Vitamin C |Vitamin D3 (as Cholecalciferol)|Vitamin E|Vitamin K (as Phytonadione)|Zinc |Capsule |InStock",
                Hidden = true, SortPrice=5.50m, SortSize=60, SizePriceList = new List<string>() { "60 CT: $5.50","90 CT: $6.25","120 CT: $4.25"}
            },
            new Product { ProductId=157,Name="Cardio B",ImageUrl="https://preprod.orthopacks.com/images/default-source/products/546060.tmb-thumb190.png?Culture=en&sfvrsn=46e6c73f_7",MainCategories="Cardiovascular Health|Essential Vitamins|Essential Health", AllCategories="Cardiovascular Health|Essential Vitamins|Essential Health|Capsule",
                Hidden = false,SortPrice=4.25m, SortSize=120, SizePriceList = new List<string>() { "120 CT: $4.25"}
            }
        };

        private static readonly List<Filter> AllFilters = new List<Filter>()
        {
            new Filter
            {
                CategoryName ="MainCategories",
                FilterValues = new List<FilterValue>()
                {
                    new FilterValue() { Name = "Cardiovascular Health" },
                    new FilterValue() { Name = "Endocrine Health" },
                    new FilterValue() { Name = "Essential Amino Acids" },
                    new FilterValue() { Name = "Essential Fatty Acids" },
                    new FilterValue() { Name = "Essential Health" },
                    new FilterValue() { Name = "Essential Minerals" },
                    new FilterValue() { Name = "Essential Nutrition" },
                    new FilterValue() { Name = "Essential Vitamins" },
                    new FilterValue() { Name = "Gastrointestinal Health" },
                    new FilterValue() { Name = "Immune Health" },
                    new FilterValue() { Name = "Men's Health" },
                    new FilterValue() { Name = "Musculoskeletal Health" },
                    new FilterValue() { Name = "New" },
                    new FilterValue() { Name = "Premier" },
                    new FilterValue() { Name = "Specialty Applications" },
                    new FilterValue() { Name = "Springboard (Kids)" },
                    new FilterValue() { Name = "Women's Health" }
                }
             },
            new Filter
            {
                CategoryName ="HealthCategories",
                FilterValues = new List<FilterValue>()
                {
                    new FilterValue() { Name = "Antioxidant Support" },
                    new FilterValue() { Name = "Cognitive Support" },
                    new FilterValue() { Name = "Detoxification Support" },
                    new FilterValue() { Name = "Digestive Regularity" },
                    new FilterValue() { Name = "Energy Support" },
                    new FilterValue() { Name = "Essential Greens" },
                    new FilterValue() { Name = "Eye Health" },
                    new FilterValue() { Name = "Functional Foods" },
                    new FilterValue() { Name = "General Wellness" },
                    new FilterValue() { Name = "Healthy Eating" },
                    new FilterValue() { Name = "HPA Axis Support" },
                    new FilterValue() { Name = "Liver Support" },
                    new FilterValue() { Name = "Metabolic Health" },
                    new FilterValue() { Name = "Mood Support" },
                    new FilterValue() { Name = "Multivitamins" },
                    new FilterValue() { Name = "Neurotransmitter Support" },
                    new FilterValue() { Name = "Omega 3s" },
                    new FilterValue() { Name = "Probiotics" },
                    new FilterValue() { Name = "Sleep Support" },
                    new FilterValue() { Name = "Stomach Health" },
                    new FilterValue() { Name = "Stress Management" }
                }
            },
            new Filter
            {
                CategoryName ="AvailableIn",
                FilterValues = new List<FilterValue>()
                {
                    new FilterValue() { Name = "Capsule" },
                    new FilterValue() { Name = "Chewable Tablets" },
                    new FilterValue() { Name = "Soft Gel Capsule" },
                    new FilterValue() { Name = "Tablet" }
                }
            },
            new Filter
            {
                CategoryName ="Ingredients",
                FilterValues = new List<FilterValue>()
                {
                    new FilterValue() { Name = "5-HTP" },
                    new FilterValue() { Name = "Iron" },
                    new FilterValue() { Name = "Artichoke Leaf Extract " },
                    new FilterValue() { Name = "Bentonite" }
                }
            },
            new Filter
            {
                CategoryName ="ExcludeIngredients",
                FilterValues = new List<FilterValue>()
                {
                    new FilterValue() { Name = "5-HTP" },
                    new FilterValue() { Name = "Iron" },
                    new FilterValue() { Name = "Artichoke Leaf Extract " },
                    new FilterValue() { Name = "Bentonite" }
                }
            },
            new Filter
            {
                CategoryName ="InStock",
                FilterValues = new List<FilterValue>()
                {
                    new FilterValue() { Name = "InStock" }
                }
            }
        };

        private static string HiddenIds = "121|137|";

        public List<Product> GetAllProducts()
        {
            return AllProducts;
        }

        public List<Filter> GetAllFilters()
        {
            return AllFilters;
        }

        public List<int> GetHiddenIds()
        {
            var result = HiddenIds.Split('|').Where(x => int.TryParse(x, out _)).Select(int.Parse).ToList();
            return result;
        }

        public void SaveHiddenItems(List<HiddenId> hiddenIds)
        {
            var hiddenIdsList = GetHiddenIds();
            foreach (var item in hiddenIds)
            {
                if (item.Hidden && !hiddenIdsList.Contains(item.ProductId))
                {
                    hiddenIdsList.Add(item.ProductId);
                }
                else if (!item.Hidden)
                {
                    hiddenIdsList.Remove(item.ProductId);
                }
            }
            HiddenIds = string.Join("|", hiddenIdsList);
            //save hiddenIds to database
        }
    }
}