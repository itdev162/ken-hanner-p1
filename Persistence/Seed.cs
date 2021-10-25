using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) {
            if (context.Posts.Count() == 0) {
                List < Post > seedPosts = new List < Post > {
                    new Post() {
                        Title = "Test Post 1", Body = "I must not test post. Test post is the mind-killer. Test post is the little-death that brings total obliteration."
                    },                                 
                    new Post() {
                        Title = "Test Post 2", Body = "I will face my test post. I will permit it to pass over me and through me. And when it has gone past I will turn the inner eye to see its path."
                    },
                    new Post() {
                        Title = "Test Post 3", Body = "Where the test post has gone there will be nothing. Only I will remain."
                    }
                };

                context.Posts.AddRange(seedPosts);

                context.SaveChanges();
            }
        }
    }
}