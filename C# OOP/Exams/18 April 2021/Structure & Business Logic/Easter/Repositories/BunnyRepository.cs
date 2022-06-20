﻿namespace Easter.Repositories
{
    using Easter.Models.Bunnies.Contracts;
    using Easter.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class BunnyRepository : IRepository<IBunny>
    {
        private readonly List<IBunny> models;
        public BunnyRepository()
        {
            this.models = new List<IBunny>();
        }
        public IReadOnlyCollection<IBunny> Models => this.models.AsReadOnly();

        public void Add(IBunny model)
        {
            this.models.Add(model);
        }

        public IBunny FindByName(string name)
        {
            return this.models.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IBunny model)
        {
            return this.models.Remove(model);
        }
    }
}
