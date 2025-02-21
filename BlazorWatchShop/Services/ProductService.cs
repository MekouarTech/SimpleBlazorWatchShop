using BlazorWatchShop.Models;

namespace BlazorWatchShop.Services
{
    public class ProductService
    {
        List<Product> _inMemoryProducts;

        public ProductService()
        {
            _inMemoryProducts = new List<Product>{
            new Product
            {
                Id = 1,
                Name = "Apple Watch Ultra 2 GPS + Cellular Titanium Case",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl = "https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/u/1/u1.jpg",
                Price = 1050,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"
            },
            new Product{
                Id = 2,
                Name= "Sumsung Watch Ultra",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl ="https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/l/d/ld0005894992_1.jpeg",
                Price = 350,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"
            },
            new Product{
                Id = 3,
                Name= "Huawei Watch Ultra 5 GPS",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl ="https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/u/1/u1.jpg",
                Price = 2550,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"

            },
            new Product
            {
                Id = 4,
                Name = "Xiomi Watch Ultra Titanium Case",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl = "https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/l/d/ld0005894992_1.jpeg",
                Price = 1650,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"

            },
            new Product
            {
                Id = 5,
                Name = "Goui Watch Cellular Titanium Case",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl = "https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/u/1/u1.jpg",
                Price = 850,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"
            },
            new Product
            {
                Id = 6,
                Name = "Apple Watch Ultra 2 GPS + Cellular Titanium Case",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl = "https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/u/1/u1.jpg",
                Price = 3050,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"
            },
            new Product
            {
                Id = 7,
                Name = "Apple Watch Ultra 2 GPS + Cellular Titanium Case",
                Description = "Jusqu’à 36 heures d’autonomie en utilisation normale. Jusqu’à 72 heures en mode économie d’énergie◊Voir les mentions légales.",
                ImageUrl = "https://uno.ma/pub/media/catalog/product/cache/af8d7fd2c4634f9c922fba76a4a30c04/u/1/u1.jpg",
                Price = 6150,
                Specifications = "<table><thead>        <tr><th>Specification</th>            <th>Details</th>        </tr>    </thead>    <tbody> <tr>            <td>Model</td>            <td>Apple Watch Series 8</td>        </tr>        <tr>            <td>Display Size</td>            <td>41mm or 45mm</td>        </tr>        <tr>            <td>Display Type</td>            <td>Always-On Retina LTPO OLED</td>        </tr>        <tr>            <td>Chipset</td>            <td>S8 SiP with 64-bit dual-core processor</td>        </tr>        <tr>            <td>Storage</td>            <td>32 GB</td>        </tr>        <tr>            <td>Battery Life</td>            <td>Up to 18 hours</td>        </tr>        <tr>            <td>Water Resistance</td>            <td>WR50 (Water resistant up to 50 meters)</td>        </tr>        <tr>            <td>Connectivity</td>            <td>Wi-Fi, Bluetooth 5.0, Ultra-Wideband (UWB)</td>        </tr><tr><td>Health Features</td><td>ECG, Blood Oxygen Monitoring, Heart Rate Tracking</td></tr><tr><td>Operating System</td><td>watchOS 9</td></tr><tr><td>Material Options</td><td>Aluminum, Stainless Steel, Titanium</td></tr><tr><td>Colors</td><td>Various colors including Midnight, Starlight, and more</td></tr></tbody></table>"
            },
        };

        }

        public List<ProductItemDto> GetProducts() => _inMemoryProducts
            .Select(x => new ProductItemDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description.Substring(0,Math.Min(50,x.Description.Length)),
                ImageUrl = x.ImageUrl,
                Price = x.Price
            }
            ).ToList();

        public Product GetProduct(int id) => _inMemoryProducts.FirstOrDefault(x => x.Id == id);
    }
}
