using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BarangayQR.OAuth.SwaggerCustomUI
{
    public class BasePathFilter : IDocumentFilter
    {
        public const string TokenEndpoint = "/token";
        public void Apply(OpenApiDocument openApiDocument, DocumentFilterContext context)
        {
            var pathItem = new OpenApiPathItem()
            {
                Operations = new Dictionary<OperationType, OpenApiOperation>()
                {
                    {
                        OperationType.Post, new OpenApiOperation()
                        {
                            Tags = new List<OpenApiTag>
                            {
                                new OpenApiTag { Name = "OAuthToken" }
                            },

                            RequestBody = new OpenApiRequestBody
                            {
                                Content = new Dictionary<string, OpenApiMediaType>
                                {
                                    ["application/x-www-form-urlencoded"] = new OpenApiMediaType
                                    {
                                        Schema = new OpenApiSchema
                                        {
                                            Type = "object",
                                            Properties = new Dictionary<string, OpenApiSchema>
                                            {
                                                ["username"] = new OpenApiSchema
                                                {
                                                    Type = "formData"
                                                },
                                                ["password"] = new OpenApiSchema
                                                {
                                                    Type = "formData"
                                                },
                                                ["grant_type"] = new OpenApiSchema
                                                {
                                                    Type = "formData"
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            Responses = new OpenApiResponses
                            {
                                ["200"] = new OpenApiResponse
                                {
                                    Description = "Success"
                                },
                                ["400"] = new OpenApiResponse
                                {
                                    Description = "Bad Request"
                                }
                            }
                        }
                    }
                }
            };

            openApiDocument.Paths.Add(TokenEndpoint, pathItem);
        }
    }
}
