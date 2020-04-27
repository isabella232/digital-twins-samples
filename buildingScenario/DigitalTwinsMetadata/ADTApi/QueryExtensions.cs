// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ADTApi
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Query.
    /// </summary>
    public static partial class QueryExtensions
    {
            /// <summary>
            /// Executes a query that allows traversing relationships and filtering by
            /// property values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='querySpecification'>
            /// The query specification to execute.
            /// </param>
            public static QueryResult QueryTwins(this IQuery operations, QuerySpecification querySpecification)
            {
                return operations.QueryTwinsAsync(querySpecification).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Executes a query that allows traversing relationships and filtering by
            /// property values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='querySpecification'>
            /// The query specification to execute.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueryResult> QueryTwinsAsync(this IQuery operations, QuerySpecification querySpecification, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryTwinsWithHttpMessagesAsync(querySpecification, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}