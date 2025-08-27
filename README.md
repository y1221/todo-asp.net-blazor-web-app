# Todo アプリ

> ASP.NET Core Blazor 学習用 Todo アプリケーション

## 🚀 クイックスタート

### 1. リポジトリのクローン

```bash
git clone https://github.com/y1221/todo-asp.net-blazor-web-app.git
cd your-repo
```

### 2. データベースマイグレーション

```bash
# 必要に応じてEFCore用CLIインストール（グローバル）
# dotnet tool install --global dotnet-ef
dotnet ef database update --project TodoBlazorApp

# またはVisual Studioのパッケージマネージャーコンソールから以下実行
Update-Database
```

### 3. アプリケーションの起動

```bash
dotnet run --project TodoBlazorApp --launch-profile https

# またはVisual Studioから実行
```

### 4. アクセス

https://localhost:7077/

## 🛠️ 技術スタック

- **言語**: C# 12.0
- **フレームワーク**: .NET 8.0
- **プロジェクトテンプレート**: Blazor Web App
- **データアクセス**: Entity Framework Core
- **データベース**: SQL Server Express 2019 LocalDB

## ⚙️ 前提条件

- **OS**: Windows
- **ランタイム**: .NET 8.0 ランタイム
- **データベース**: SQL Server (Windows 認証)

## 👨‍💻 作者

**おかゆ**

<img src="./docs/images/icon.jpeg" alt="プロフィール" width="20%">

- GitHub: [@y1221](https://github.com/y1221)
- Qiita: [@okayu\_\_11](https://qiita.com/okayu__11)
- X: [@okayu\_\_11](https://twitter.com/okayu__11)
