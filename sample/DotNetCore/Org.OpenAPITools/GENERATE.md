## .NET Core用クライアント

OpenAPI Generatorを使用して、自動生成した.NET Core用クライアントです。

(ビルドまでしか確認していません。動作は保証しません。)

生成にはOpenAPI Generator公式のdockerイメージを使用しました。

.NET Framework Standard2.0から.net core 3.1へ変更。

```
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
  -i /local/reference/kabu_STATION_API.yaml \
  -g csharp-netcore \
  --skip-validate-spec \
  --additional-properties=generateAliasAsModel=true,optionalEmitDefaultValues=true,targetFramework=netcoreapp3.1 \
  -o /local/sample/DotNetCore/Org.OpenAPITools
```

"--additional-properties optionalEmitDefaultValues=true"はデフォルト(0)を指定するとパラメータが省略されてしまうのを回避するために設定しています。

検証用には、BasePathを指定してください。
Config.Serversに定義が設定されています。
- 本番用：Config.Servers[0]["url"] //デフォルト
- 検証用：Config.Servers[1]["url"]

**注意**
- OrdersSuccessが変換できてないようです。そのため、OrdersGetはobjectが返されています。
- ~~PositionsSuccessが変換できていないようです。そのため、PositionsGetはobjectが返されています。~~
- ~~RankingGetはビルド自体ができないため、戻り値をCommonRankingResponseに固定しています。~~

```csharp
    //本番用
    Configuration config = new Configuration();
    //config.BasePath = (string)config.Servers[0]["url"];
    var apiInstance = new AuthApi(config);
    var req = new RequestToken(); // RequestToken
```

```csharp
    //検証用
    Configuration config = new Configuration();
    config.BasePath = (string)config.Servers[1]["url"];
    var apiInstance = new AuthApi(config);
    var req = new RequestToken(); // RequestToken
```

レスポンスのパラメータの一部(nullになる可能性があるモノ)についてはエラーになります。

nulltableにしましょう(double → double?)

