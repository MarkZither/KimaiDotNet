# IO.Swagger.Model.CustomerEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Name** | **string** |  | 
**Number** | **string** |  | [optional] 
**Comment** | **string** |  | [optional] 
**Visible** | **bool?** |  | 
**Company** | **string** |  | [optional] 
**VatId** | **string** |  | [optional] 
**Contact** | **string** |  | [optional] 
**Address** | **string** |  | [optional] 
**Country** | **string** |  | 
**Currency** | **string** |  | 
**Phone** | **string** |  | [optional] 
**Fax** | **string** |  | [optional] 
**Mobile** | **string** |  | [optional] 
**Email** | **string** | Limited via RFC to 254 chars | [optional] 
**Homepage** | **string** |  | [optional] 
**Timezone** | **string** | Length was determined by a MySQL column via \&quot;use mysql;describe time_zone_name;\&quot; | 
**Budget** | **float?** |  | 
**TimeBudget** | **int?** |  | 
**MetaFields** | [**List&lt;CustomerMeta&gt;**](CustomerMeta.md) | All visible meta (custom) fields registered with this customer | [optional] 
**Teams** | [**List&lt;Team&gt;**](Team.md) | If no team is assigned, everyone can access the customer | [optional] 
**Color** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

