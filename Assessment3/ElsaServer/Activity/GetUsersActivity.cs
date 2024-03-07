using Elsa.Extensions;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using Elsa.Workflows.Models;
using ElsaServer.Models;

namespace ElsaServer.Activity
{
    /// <summary>
    /// Fetch users from regres
    /// </summary>
    [Activity("Elsa", "GetUsers", "Fetch users from the regres api.", Kind = ActivityKind.Task)]
    public class GetUsersActivity : CodeActivity<ICollection<User>>
    {
        [Input(Description = "The page of users to fetch.")]
        public Input<int> Page { get; set; } = default!;

        [Input(Description = "The number of users to fetch per page.")]
        public Input<int> PageSize { get; set; } = default!;

        /// <inheritdoc />
        protected override async ValueTask ExecuteAsync(ActivityExecutionContext context)
        {
            var cancellationToken = context.CancellationToken;
            var page = Page.Get(context);
            var pageSize = PageSize.Get(context);

            var httpClientFactory = context.GetRequiredService<IHttpClientFactory>();
            var client = httpClientFactory.CreateClient();

            var url = $"https://reqres.in/api/users?page={page}&per_page={pageSize}";
            var apiResult = await client.GetAsync(url, cancellationToken);

            apiResult.EnsureSuccessStatusCode();

            var root = await apiResult.Content.ReadFromJsonAsync<Root>();

            Result.Set(context, root?.Users);
        }
    }
}
