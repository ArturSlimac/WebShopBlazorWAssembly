using Microsoft.AspNetCore.Mvc;

namespace WebShopBlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "The Catcher in the Rye",
            Description = "The Catcher in the Rye is an American novel by J. D. Salinger that was partially published in serial form 1945–46 before being novelized in 1951. Originally intended for adults, it is often read by adolescents for its themes of angst and alienation, and as a critique of superficiality in society.[4][5] The novel also deals with complex issues of innocence, identity, belonging, loss, connection, sex, and depression. The main character, Holden Caulfield, has become an icon for teenage rebellion.[6] Caulfield, nearly of age, gives his opinion on a wide variety of topics as he narrates his recent life events.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/89/The_Catcher_in_the_Rye_%281951%2C_first_edition_cover%29.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id = 2,
            Title = "War and Peace",
            Description = "War and Peace[a] is a literary work by Russian author Leo Tolstoy. Set during the Napoleonic Wars, the work mixes fictional narrative with chapters discussing history and philosophy. First published serially beginning in 1865, the work was rewritten and published in its entirety in 1869. It is regarded as Tolstoy's finest literary achievement and remains an internationally praised classic of world literature.[1][2][3]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/af/Tolstoy_-_War_and_Peace_-_first_edition%2C_1869.jpg",
            Price = 10.99m
        },
        new Product
        {
            Id = 3,
            Title = "Lolita",
            Description = "Lolita is a 1955 novel written by Russian-American novelist Vladimir Nabokov. The novel is notable for its controversial subject: the protagonist and unreliable narrator, a middle-aged literature professor under the pseudonym Humbert Humbert, is a Parisian obsessed with a 12-year-old New England girl, Dolores Haze, whom he kidnaps and sexually abuses after becoming her stepfather. 'Lolita', the Spanish nickname for Dolores, is what he calls her privately. The novel was originally written in English, but fear of censorship in the U.S. (where Nabokov lived) and Britain led to it being first published in Paris, France in 1955 by Olympia Press.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/57/Lolita_1955.JPG",
            Price = 11.99m
        },
    };
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
            
        }
    }
}
