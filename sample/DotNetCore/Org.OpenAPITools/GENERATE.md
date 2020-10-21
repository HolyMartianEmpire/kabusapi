## .NET Core用クライアント

OpenAPI Generatorを使用して、自動生成した.NET Core用クライアントです。

生成にはOpenAPI Generator公式のdockerイメージを使用しました。

```
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
  -i /local/reference/kabu_STATION_API.yaml \
  -g csharp-netcore \
  --skip-validate-spec \
  --additional-properties optionalEmitDefaultValues=true \
  -o /local/sample/DotNetCore/Org.OpenAPITools
```

"--additional-properties optionalEmitDefaultValues=true"はデフォルト(0)を指定するとパラメータが省略されてしまうのを回避するために設定しています。

利用時には、BasePathを指定してください。
(yamlを改変して設定不要にしようかと思いましたが、検証用は別ポートのようなのでやめました。)

注) 現時点でOrdersSuccessが変換できてないようです。そのため、OrdersGetはobjectが返されています。

```csharp
    //本番用
    Configuration config = new Configuration();
    config.BasePath = "http://localhost:18080/kabusapi";
    var apiInstance = new AuthApi(config);
    var req = new RequestToken(); // RequestToken
```

```csharp
    //検証用
    Configuration config = new Configuration();
    config.BasePath = "http://localhost:18081/kabusapi";
    var apiInstance = new AuthApi(config);
    var req = new RequestToken(); // RequestToken
```

レスポンスのパラメータの一部(nullになる可能性があるモノ)についてはエラーになります。

nulltableにしましょう(double → double?)

