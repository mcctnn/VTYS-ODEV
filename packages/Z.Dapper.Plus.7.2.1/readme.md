## Dapper Plus

Dapper Plus is a high-performance NuGet package providing essential extensions for Dapper, a popular micro-ORM for .NET. It is specifically designed to simplify and enhance CRUD (Create, Read, Update, Delete) operations in .NET applications. 

The Dapper Plus library offers a variety of features for bulk operations, including `BulkInsert`, `BulkDelete`, `BulkUpdate`, and `BulkMerge` — features that are not provided by Dapper by default.

The primary advantages of using Dapper Plus include improved efficiency and speed in managing large volumes of data in .NET applications. Dapper Plus makes your applications faster, simpler to write, and easier to maintain, while preserving the versatility and performance benefits of Dapper.

Resources:

- [Official Website](https://dapper-plus.net/): For comprehensive information, updates, tutorials, and more, visit our official website. Learn how Dapper Plus can transform your application's data layer.
- [Contact Us](https://dapper-plus.net/contact-us): If you have any questions or require assistance, don't hesitate to reach out. We're here to help you maximize the benefits of Dapper Plus.
- [GitHub Issues](https://github.com/zzzprojects/Dapper-Plus/issues): If you encounter an issue or have a feature request, let us know on GitHub. Your feedback is invaluable to us in improving Dapper Plus.

## Supported .NET Versions

Dapper Plus is designed to work with a broad spectrum of .NET versions, including .NET Framework 4.0 and onwards, as well as .NET Standard 2.0 and beyond. Additionally, it is compatible with the most recent .NET versions.

We always recommand to use the latest version of Dapper Plus package. This ensures that your application benefits from the latest advancements in performance, security, and features provided by Dapper Plus.

## Main Features

Dapper Plus provides a robust suite of bulk operations that can enhance performance when managing data. These features aim to handle thousands of entities with ease:

- [BulkInsert](https://dapper-plus.net/bulk-insert): This is the fastest method for inserting thousands of entities in your database, saving you valuable processing time.
- [BulkUpdate](https://dapper-plus.net/bulk-update): This feature allows for rapid updates to thousands of entities, thereby maintaining data consistency and accuracy with impressive speed.
- [BulkDelete](https://dapper-plus.net/bulk-delete): This allows for the swift removal of thousands of entities, ensuring efficient data management.
- [BulkMerge (BulkUpsert)](https://dapper-plus.net/bulk-merge): This feature combines insert and update operations into a single efficient transaction, making data management more streamlined.

For a more detailed explanation and examples of each operation, please visit our [documentation page](https://dapper-plus.net/overview). It offers a wealth of information and practical examples to help you utilize Dapper Plus to its full potential.

## Getting Started

One of the major advantages of Dapper Plus is its simplicity and ease of use, particularly for those already comfortable with Dapper. Suppose you need to insert thousands of customers into your database. In that case, a single line of code is all it takes:

```csharp
connection.BulkInsert(customers);
```

This line of code utilizes the `BulkInsert` method that extends your `IDbConnection`, empowering you with the capability to perform bulk operations with ease.

Moreover, if your task involves inserting only the customers who do not already exist in your database, you can accomplish this using the `InsertIfNotExists` option:

```csharp
connection.UseBulkOptions(options => { options.InsertIfNotExists = true;})
          .BulkInsert(customers);
```

With this approach, the operation becomes not only efficient but also intelligent, assisting you in maintaining the integrity of your data.

To explore various use-cases with the library, visit our collection of online examples:

- [Dapper Plus - Online Examples](https://dapper-plus.net/online-examples)

These examples are designed to provide a practical understanding of Dapper Plus, showcasing its powerful features and flexible options in different scenarios. Use these to familiarize yourself with Dapper Plus and unlock its full potential in your applications.

## Advanced Usage

### Single Action

Methods prefixed with `Single` are included for FREE in Dapper Plus (doesn't require a license). These methods work with one entity at a time, allowing you to use the same customizations as the `Bulk` counterparts but without the associated performance enhancements.

The Single Action operations include:

- `SingleInsert`
- `SingleUpdate`
- `SingleDelete`
- `SingleMerge`

Here's an example of how to use the `SingleInsert` operation:

```csharp
foreach(var customer in customers)
{
	connection.SingleInsert(customer);
}
```

In this example, the `SingleInsert` method is used within a loop to insert individual customers into the database. Although this approach doesn't provide the performance benefits of the bulk operations, it allows for granular control over each operation compared to write yourself a SQL statement.

### Bulk Insert

The `BulkInsert` extension method allow you to insert multiple rows with Bulk Operations. This is ideal for scenarios where you have large amounts of data to insert into your database and need a performant way to do so.

Here are some of the common options available:

- **InsertIfNotExists**: This option ensures only new entities that don't already exist in the database are inserted. This is great for maintaining data integrity and avoiding duplicate entries.
- **InsertKeepIdentity**: This option allows you to insert specific values into an identity column from your entities. This is useful when you want to maintain the same identity values as in your source data.

Here is an example demonstrating the use of `InsertIfNotExists` option with the `BulkInsert` method:

```csharp
connection.UseBulkOptions(options => { options.InsertIfNotExists = true;})
          .BulkInsert(customers);
```

In the example above, only those customers who do not already exist in the database will be inserted. This helps prevent duplication and ensures the insertion operation is as efficient as possible.

These options offer extensive control over your bulk insert operations, making Dapper Plus a powerful tool for managing large-scale data operations.

### Bulk Update

The Dapper Plus `BulkUpdate` method provides an efficient and versatile approach for executing large-scale updates. You can configure the method to tailor your operations according to specific requirements.

Creating an instance context allows you to customize your mapping within a method if you need to use a custom key, or update a subset of your properties:

```csharp
public void MyMethodName()
{
	var connection = new SqlConnection(FiddleHelper.GetConnectionStringSqlServer());

	var context = new DapperPlusContext(connection);
	context.Entity<Customer>().Key(x => new { x.Email }).Map(x => new { x.FirstName, x.LastName });

	context.BulkUpdate(customers);
}
```

In the example above, the `BulkUpdate` operation updates only the `FirstName` and `LastName` properties of the customers whose `Email` matches the entities in your list. This level of control and flexibility makes it possible to update specific columns based on custom keys, which can be very useful when dealing with complex business rules or performance optimization scenarios.

This is just one of the many ways Dapper Plus can be configured to meet a wide range of operational requirements.

### Bulk Delete

The `BulkDelete` extension method enables you to perform efficient and large-scale deletion operations. By using this method, you can delete multiple rows simultaneously, saving both time and computational resources.

Asynchronous operation is also supported with `BulkDelete`, making it ideal for scenarios where non-blocking operation is critical for application performance. To perform a deletion asynchronously, use the `BulkActionAsync` method and call `BulkDelete` within:

```csharp
var task = connection.BulkActionAsync(x => x.BulkDelete(customers), cancellationToken);
```

In the example above, the deletion operation for a list of customers is carried out asynchronously, enhancing the performance of your application by not blocking the main execution thread.

Asynchronous operations can significantly boost your application's performance when handling large amounts of data, making Dapper Plus an ideal choice for data-intensive .NET applications.

### Bulk Merge / Bulk Upsert

The `BulkMerge` extension method allow you to execute `Upsert` operations using bulk operations. An `Upsert` (Update/Insert) operation updates existing rows and inserts non-existing rows. 

Several configuration options are available for fine-tuning your `BulkMerge` operations:

- **ColumnPrimaryKeyExpression**: Allows you to define a custom key to verify the existence of entities.
- **IgnoreOnMergeInsertExpression**: Lets you ignore certain columns during the insert phase of the merge operation.
- **IgnoreOnMergeUpdateExpression**: Allows you to ignore certain columns during the update phase of the merge operation.

Here is an example showcasing the use of these options:

```csharp
public void MyMethodName()
{
	var connection = new SqlConnection(FiddleHelper.GetConnectionStringSqlServer());

	var context = new DapperPlusContext(connection);
	context.Entity<Customer>().UseBulkOptions(x => {
		options.ColumnPrimaryKeyExpression = x => new { x.Code };
		options.IgnoreOnMergeInsertExpression = x => new { x.UpdatedDate, x.UpdatedBy };
		options.IgnoreOnMergeUpdateExpression = x => new { x.CreatedDate, x.CreatedBy };
	});

	context.BulkMerge(customers);
}
```

In this example, `BulkMerge` is used to upsert a list of customers. The merge operation uses `Code` as the primary key. During the insertion phase, `UpdatedDate` and `UpdatedBy` properties are ignored. During the update phase, `CreatedDate` and `CreatedBy` properties are ignored.

Effectively utilizing these options, Dapper Plus facilitates robust and flexible upsert operations, enabling complex data manipulation with relative ease and efficiency.

## Release Notes

For a detailed account of improvements, bug fixes, and updates in each version of Dapper Plus, we recommend consulting the official [Release Notes](https://github.com/zzzprojects/Dapper-Plus/releases) in our GitHub repository.

The Release Notes provide critical insights about each release, describing new features, acknowledging resolved issues, and noting any breaking changes, if applicable. We strongly recommend reviewing these notes before upgrading to a newer version. This practice ensures that you take full advantage of new features and helps avoid unexpected issues.

## License

Dapper Plus operates under a paid licensing model. To acquire a license, please visit our official [Pricing Page](https://dapper-plus.net/pricing) on the Dapper Plus website. It offers a range of licensing options, so you can choose the one that best fits your needs and requirements.