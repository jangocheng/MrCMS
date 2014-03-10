using System;
using System.Collections.Generic;
using MrCMS.Entities.Resources;

namespace MrCMS.Services.Resources
{
    public interface IStringResourceProvider
    {
        string GetValue(string key, string defaultValue = null);
        IEnumerable<string> GetOverriddenLanguages();
        IEnumerable<string> GetOverriddenLanguages(string key);
        void Add(StringResource resource);
        void Update(StringResource resource);
        void Delete(StringResource resource);
        IEnumerable<StringResource> ResourcesForSite { get; }
    }
}