﻿# KimaiDotNet
 
This repo is archived, please see [KimaiDotNet](https://github.com/KimaiDotNet)

A client library for the Kimai Time Tracking API.


<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActivityApi* | [**ApiActivitiesGet**](docs/ActivityApi.md#apiactivitiesget) | **GET** /api/activities | Returns a collection of activities
*ActivityApi* | [**ApiActivitiesIdGet**](docs/ActivityApi.md#apiactivitiesidget) | **GET** /api/activities/{id} | Returns one activity
*ActivityApi* | [**ApiActivitiesIdMetaPatch**](docs/ActivityApi.md#apiactivitiesidmetapatch) | **PATCH** /api/activities/{id}/meta | Sets the value of a meta-field for an existing activity
*ActivityApi* | [**ApiActivitiesIdPatch**](docs/ActivityApi.md#apiactivitiesidpatch) | **PATCH** /api/activities/{id} | Update an existing activity
*ActivityApi* | [**ApiActivitiesIdRatesGet**](docs/ActivityApi.md#apiactivitiesidratesget) | **GET** /api/activities/{id}/rates | Returns a collection of all rates for one activity
*ActivityApi* | [**ApiActivitiesIdRatesPost**](docs/ActivityApi.md#apiactivitiesidratespost) | **POST** /api/activities/{id}/rates | Adds a new rate to an activity
*ActivityApi* | [**ApiActivitiesIdRatesRateIdDelete**](docs/ActivityApi.md#apiactivitiesidratesrateiddelete) | **DELETE** /api/activities/{id}/rates/{rateId} | Deletes one rate for an activity
*ActivityApi* | [**ApiActivitiesPost**](docs/ActivityApi.md#apiactivitiespost) | **POST** /api/activities | Creates a new activity
*CustomerApi* | [**ApiCustomersGet**](docs/CustomerApi.md#apicustomersget) | **GET** /api/customers | Returns a collection of customers
*CustomerApi* | [**ApiCustomersIdGet**](docs/CustomerApi.md#apicustomersidget) | **GET** /api/customers/{id} | Returns one customer
*CustomerApi* | [**ApiCustomersIdMetaPatch**](docs/CustomerApi.md#apicustomersidmetapatch) | **PATCH** /api/customers/{id}/meta | Sets the value of a meta-field for an existing customer
*CustomerApi* | [**ApiCustomersIdPatch**](docs/CustomerApi.md#apicustomersidpatch) | **PATCH** /api/customers/{id} | Update an existing customer
*CustomerApi* | [**ApiCustomersIdRatesGet**](docs/CustomerApi.md#apicustomersidratesget) | **GET** /api/customers/{id}/rates | Returns a collection of all rates for one customer
*CustomerApi* | [**ApiCustomersIdRatesPost**](docs/CustomerApi.md#apicustomersidratespost) | **POST** /api/customers/{id}/rates | Adds a new rate to a customer
*CustomerApi* | [**ApiCustomersIdRatesRateIdDelete**](docs/CustomerApi.md#apicustomersidratesrateiddelete) | **DELETE** /api/customers/{id}/rates/{rateId} | Deletes one rate for an customer
*CustomerApi* | [**ApiCustomersPost**](docs/CustomerApi.md#apicustomerspost) | **POST** /api/customers | Creates a new customer
*DefaultApi* | [**ApiConfigI18nGet**](docs/DefaultApi.md#apiconfigi18nget) | **GET** /api/config/i18n | Returns the user specific locale configuration
*DefaultApi* | [**ApiConfigTimesheetGet**](docs/DefaultApi.md#apiconfigtimesheetget) | **GET** /api/config/timesheet | Returns the timesheet configuration
*DefaultApi* | [**ApiPingGet**](docs/DefaultApi.md#apipingget) | **GET** /api/ping | A testing route for the API
*DefaultApi* | [**ApiVersionGet**](docs/DefaultApi.md#apiversionget) | **GET** /api/version | Returns information about the Kimai release
*ProjectApi* | [**ApiProjectsGet**](docs/ProjectApi.md#apiprojectsget) | **GET** /api/projects | Returns a collection of projects.
*ProjectApi* | [**ApiProjectsIdGet**](docs/ProjectApi.md#apiprojectsidget) | **GET** /api/projects/{id} | Returns one project
*ProjectApi* | [**ApiProjectsIdMetaPatch**](docs/ProjectApi.md#apiprojectsidmetapatch) | **PATCH** /api/projects/{id}/meta | Sets the value of a meta-field for an existing project
*ProjectApi* | [**ApiProjectsIdPatch**](docs/ProjectApi.md#apiprojectsidpatch) | **PATCH** /api/projects/{id} | Update an existing project
*ProjectApi* | [**ApiProjectsIdRatesGet**](docs/ProjectApi.md#apiprojectsidratesget) | **GET** /api/projects/{id}/rates | Returns a collection of all rates for one project
*ProjectApi* | [**ApiProjectsIdRatesPost**](docs/ProjectApi.md#apiprojectsidratespost) | **POST** /api/projects/{id}/rates | Adds a new rate to an project
*ProjectApi* | [**ApiProjectsIdRatesRateIdDelete**](docs/ProjectApi.md#apiprojectsidratesrateiddelete) | **DELETE** /api/projects/{id}/rates/{rateId} | Deletes one rate for an project
*ProjectApi* | [**ApiProjectsPost**](docs/ProjectApi.md#apiprojectspost) | **POST** /api/projects | Creates a new project
*TagApi* | [**ApiTagsGet**](docs/TagApi.md#apitagsget) | **GET** /api/tags | Fetch all existing tags
*TagApi* | [**ApiTagsIdDelete**](docs/TagApi.md#apitagsiddelete) | **DELETE** /api/tags/{id} | Delete a tag
*TagApi* | [**ApiTagsPost**](docs/TagApi.md#apitagspost) | **POST** /api/tags | Creates a new tag
*TeamApi* | [**ApiTeamsGet**](docs/TeamApi.md#apiteamsget) | **GET** /api/teams | Fetch all existing teams
*TeamApi* | [**ApiTeamsIdActivitiesActivityIdDelete**](docs/TeamApi.md#apiteamsidactivitiesactivityiddelete) | **DELETE** /api/teams/{id}/activities/{activityId} | Revokes access for an activity from a team
*TeamApi* | [**ApiTeamsIdActivitiesActivityIdPost**](docs/TeamApi.md#apiteamsidactivitiesactivityidpost) | **POST** /api/teams/{id}/activities/{activityId} | Grant the team access to an activity
*TeamApi* | [**ApiTeamsIdCustomersCustomerIdDelete**](docs/TeamApi.md#apiteamsidcustomerscustomeriddelete) | **DELETE** /api/teams/{id}/customers/{customerId} | Revokes access for a customer from a team
*TeamApi* | [**ApiTeamsIdCustomersCustomerIdPost**](docs/TeamApi.md#apiteamsidcustomerscustomeridpost) | **POST** /api/teams/{id}/customers/{customerId} | Grant the team access to a customer
*TeamApi* | [**ApiTeamsIdDelete**](docs/TeamApi.md#apiteamsiddelete) | **DELETE** /api/teams/{id} | Delete a team
*TeamApi* | [**ApiTeamsIdGet**](docs/TeamApi.md#apiteamsidget) | **GET** /api/teams/{id} | Returns one team
*TeamApi* | [**ApiTeamsIdMembersUserIdDelete**](docs/TeamApi.md#apiteamsidmembersuseriddelete) | **DELETE** /api/teams/{id}/members/{userId} | Removes a member from the team
*TeamApi* | [**ApiTeamsIdMembersUserIdPost**](docs/TeamApi.md#apiteamsidmembersuseridpost) | **POST** /api/teams/{id}/members/{userId} | Add a new member to a team
*TeamApi* | [**ApiTeamsIdPatch**](docs/TeamApi.md#apiteamsidpatch) | **PATCH** /api/teams/{id} | Update an existing team
*TeamApi* | [**ApiTeamsIdProjectsProjectIdDelete**](docs/TeamApi.md#apiteamsidprojectsprojectiddelete) | **DELETE** /api/teams/{id}/projects/{projectId} | Revokes access for a project from a team
*TeamApi* | [**ApiTeamsIdProjectsProjectIdPost**](docs/TeamApi.md#apiteamsidprojectsprojectidpost) | **POST** /api/teams/{id}/projects/{projectId} | Grant the team access to a project
*TeamApi* | [**ApiTeamsPost**](docs/TeamApi.md#apiteamspost) | **POST** /api/teams | Creates a new team
*TimesheetApi* | [**ApiTimesheetsActiveGet**](docs/TimesheetApi.md#apitimesheetsactiveget) | **GET** /api/timesheets/active | Returns the collection of active timesheet records
*TimesheetApi* | [**ApiTimesheetsGet**](docs/TimesheetApi.md#apitimesheetsget) | **GET** /api/timesheets | Returns a collection of timesheet records
*TimesheetApi* | [**ApiTimesheetsIdDelete**](docs/TimesheetApi.md#apitimesheetsiddelete) | **DELETE** /api/timesheets/{id} | Delete an existing timesheet record
*TimesheetApi* | [**ApiTimesheetsIdDuplicatePatch**](docs/TimesheetApi.md#apitimesheetsidduplicatepatch) | **PATCH** /api/timesheets/{id}/duplicate | Duplicates an existing timesheet record
*TimesheetApi* | [**ApiTimesheetsIdExportPatch**](docs/TimesheetApi.md#apitimesheetsidexportpatch) | **PATCH** /api/timesheets/{id}/export | Switch the export state of a timesheet record to (un-)lock it
*TimesheetApi* | [**ApiTimesheetsIdGet**](docs/TimesheetApi.md#apitimesheetsidget) | **GET** /api/timesheets/{id} | Returns one timesheet record
*TimesheetApi* | [**ApiTimesheetsIdMetaPatch**](docs/TimesheetApi.md#apitimesheetsidmetapatch) | **PATCH** /api/timesheets/{id}/meta | Sets the value of a meta-field for an existing timesheet.
*TimesheetApi* | [**ApiTimesheetsIdPatch**](docs/TimesheetApi.md#apitimesheetsidpatch) | **PATCH** /api/timesheets/{id} | Update an existing timesheet record
*TimesheetApi* | [**ApiTimesheetsIdRestartPatch**](docs/TimesheetApi.md#apitimesheetsidrestartpatch) | **PATCH** /api/timesheets/{id}/restart | Restarts a previously stopped timesheet record for the current user
*TimesheetApi* | [**ApiTimesheetsIdStopPatch**](docs/TimesheetApi.md#apitimesheetsidstoppatch) | **PATCH** /api/timesheets/{id}/stop | Stops an active timesheet record
*TimesheetApi* | [**ApiTimesheetsPost**](docs/TimesheetApi.md#apitimesheetspost) | **POST** /api/timesheets | Creates a new timesheet record
*TimesheetApi* | [**ApiTimesheetsRecentGet**](docs/TimesheetApi.md#apitimesheetsrecentget) | **GET** /api/timesheets/recent | Returns the collection of recent user activities
*UserApi* | [**ApiUsersGet**](docs/UserApi.md#apiusersget) | **GET** /api/users | Returns the collection of all registered users
*UserApi* | [**ApiUsersIdGet**](docs/UserApi.md#apiusersidget) | **GET** /api/users/{id} | Return one user entity
*UserApi* | [**ApiUsersIdPatch**](docs/UserApi.md#apiusersidpatch) | **PATCH** /api/users/{id} | Update an existing user
*UserApi* | [**ApiUsersMeGet**](docs/UserApi.md#apiusersmeget) | **GET** /api/users/me | Return the current user entity
*UserApi* | [**ApiUsersPost**](docs/UserApi.md#apiuserspost) | **POST** /api/users | Creates a new user


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.Activity](docs/Activity.md)
 - [IO.Swagger.Model.ActivityCollection](docs/ActivityCollection.md)
 - [IO.Swagger.Model.ActivityEditForm](docs/ActivityEditForm.md)
 - [IO.Swagger.Model.ActivityEntity](docs/ActivityEntity.md)
 - [IO.Swagger.Model.ActivityExpanded](docs/ActivityExpanded.md)
 - [IO.Swagger.Model.ActivityMeta](docs/ActivityMeta.md)
 - [IO.Swagger.Model.ActivityRate](docs/ActivityRate.md)
 - [IO.Swagger.Model.ActivityRateForm](docs/ActivityRateForm.md)
 - [IO.Swagger.Model.Body](docs/Body.md)
 - [IO.Swagger.Model.Body1](docs/Body1.md)
 - [IO.Swagger.Model.Body2](docs/Body2.md)
 - [IO.Swagger.Model.Body3](docs/Body3.md)
 - [IO.Swagger.Model.Body4](docs/Body4.md)
 - [IO.Swagger.Model.Customer](docs/Customer.md)
 - [IO.Swagger.Model.CustomerCollection](docs/CustomerCollection.md)
 - [IO.Swagger.Model.CustomerEditForm](docs/CustomerEditForm.md)
 - [IO.Swagger.Model.CustomerEntity](docs/CustomerEntity.md)
 - [IO.Swagger.Model.CustomerMeta](docs/CustomerMeta.md)
 - [IO.Swagger.Model.CustomerRate](docs/CustomerRate.md)
 - [IO.Swagger.Model.CustomerRateForm](docs/CustomerRateForm.md)
 - [IO.Swagger.Model.I18nConfig](docs/I18nConfig.md)
 - [IO.Swagger.Model.Project](docs/Project.md)
 - [IO.Swagger.Model.ProjectCollection](docs/ProjectCollection.md)
 - [IO.Swagger.Model.ProjectEditForm](docs/ProjectEditForm.md)
 - [IO.Swagger.Model.ProjectEntity](docs/ProjectEntity.md)
 - [IO.Swagger.Model.ProjectExpanded](docs/ProjectExpanded.md)
 - [IO.Swagger.Model.ProjectMeta](docs/ProjectMeta.md)
 - [IO.Swagger.Model.ProjectRate](docs/ProjectRate.md)
 - [IO.Swagger.Model.ProjectRateForm](docs/ProjectRateForm.md)
 - [IO.Swagger.Model.TagEditForm](docs/TagEditForm.md)
 - [IO.Swagger.Model.TagEntity](docs/TagEntity.md)
 - [IO.Swagger.Model.Team](docs/Team.md)
 - [IO.Swagger.Model.TeamCollection](docs/TeamCollection.md)
 - [IO.Swagger.Model.TeamEditForm](docs/TeamEditForm.md)
 - [IO.Swagger.Model.TeamEntity](docs/TeamEntity.md)
 - [IO.Swagger.Model.TimesheetCollection](docs/TimesheetCollection.md)
 - [IO.Swagger.Model.TimesheetCollectionExpanded](docs/TimesheetCollectionExpanded.md)
 - [IO.Swagger.Model.TimesheetConfig](docs/TimesheetConfig.md)
 - [IO.Swagger.Model.TimesheetEditForm](docs/TimesheetEditForm.md)
 - [IO.Swagger.Model.TimesheetEntity](docs/TimesheetEntity.md)
 - [IO.Swagger.Model.TimesheetEntityExpanded](docs/TimesheetEntityExpanded.md)
 - [IO.Swagger.Model.TimesheetMeta](docs/TimesheetMeta.md)
 - [IO.Swagger.Model.User](docs/User.md)
 - [IO.Swagger.Model.UserCollection](docs/UserCollection.md)
 - [IO.Swagger.Model.UserCreateForm](docs/UserCreateForm.md)
 - [IO.Swagger.Model.UserEditForm](docs/UserEditForm.md)
 - [IO.Swagger.Model.UserEntity](docs/UserEntity.md)
 - [IO.Swagger.Model.Version](docs/Version.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="apiToken"></a>
### apiToken

- **Type**: API key
- **API key parameter name**: X-AUTH-TOKEN
- **Location**: HTTP header

<a name="apiUser"></a>
### apiUser

- **Type**: API key
- **API key parameter name**: X-AUTH-USER
- **Location**: HTTP header

