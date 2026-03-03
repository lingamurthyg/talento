/*
===================================================================================================================
Created By: Ramana Bandla
Created Date : 9/03/2015
Description: Defining the methods for getting the data from service by making cal to all RESTFULL services
Modified By : 
Modified Date: 

===================================================================================================================
*/
using System;
using System.Collections.Generic;
using RestSharp;
using System.Net;
using Newtonsoft.Json;

namespace Trianz.Enterprise.Operations.Models
{
    public class ServiceAgent
    {

        /// <summary>
        /// Description : Getting the Total MsterLookup details
        /// </summary>
        /// <returns></returns>
        public string GetLookupdata()
        {
            try
            {
                var client = new RestClient(UiConstants.GetLookupService);
                var request = new RestRequest(UiConstants.GetAllLookUpMethods);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("lookuptype", "");
                var response = client.Execute(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                   return response.Content;
                   
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
            //var errorData = JsonConvert.DeserializeObject<ErrorData>(response.Content);
            ////user/unhandled handled exceptions
            //throw new Exception(response.StatusDescription, response.ErrorException, errorData);

        }
        /// <summary>
        /// Description : Getting the  MsterLookup details based on lookuptype
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parentCode"></param>
        /// <param name="userCreds"></param>
        /// <returns></returns>
        public List<MasterLookUp> GetLookupdata(string LookupType)
        {
            try
            {
                var client = new RestClient(UiConstants.GetLookupService);
                var request = new RestRequest(UiConstants.GetBasedOnLookupType);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("LookupType", LookupType);
                // request.AddUrlSegment("parentId", parentCode);
                var response = client.Execute<List<MasterLookUp>>(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Data;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        /// <summary>
        /// Description : Getting the All Application Settings
        /// </summary>
        /// <returns></returns>
        public List<Application> GetAllApplicationSettings()
        {
            try
            {
                var client = new RestClient(UiConstants.GetLookupService);
                var request = new RestRequest(UiConstants.GetApplicationSetting);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("AppSetting", "AppSetting");
                var response = client.Execute<List<Application>>(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Data;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        /// <summary>
        /// Description : Getting the Application Settings based on ApplicationId
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public List<Application> GetApplicationSettings(string application)
        {
            try
            {
                var client = new RestClient(UiConstants.GetLookupService);
                var request = new RestRequest(UiConstants.GetApplicationIdSetting);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("application", "application");
                var response = client.Execute<List<Application>>(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Data;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        /// <summary>
        /// Description : Getting the All Employees details
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            try
            {
                var client = new RestClient(UiConstants.GetEmployeeService);
                var request = new RestRequest(UiConstants.GetGetEmployees);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("employee", "empid");
                var response = client.Execute<List<Employee>>(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Data;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }

            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        /// <summary>
        ///  Description : Getting the Employee details based on EmailId
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public Employee GetEmployeeByEmail(string Email)
        {
            try
            {
                var client = new RestClient(UiConstants.GetEmployeeService);
                var request = new RestRequest(UiConstants.GetEmployeeByEmail);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("EMAILID", Email);
                var response = client.Execute<Employee>(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Data;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        /// <summary>
        ///  Description : Getting the Employee details based EmployeeId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployeeByID(string id)
        {
            try
            {
                var client = new RestClient(UiConstants.GetEmployeeService);
                var request = new RestRequest(UiConstants.GetEmployeeByID);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("ID", id);
                var response = client.Execute<Employee>(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Data;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        public string GetAllHRRFDetails()
        {
            try
            {
                RestClient client = new RestClient(UiConstants.HRRFCliUrl);
                var request = new RestRequest(UiConstants.GetHRRFDetails);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("hrrf", "");
                 var response = client.Execute(request);
               // var response = client.Execute(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return  response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }

            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        public string GetHRRFByHRRFNumber(string HRRFNo)
        {
            try
            {
                var client = new RestClient(UiConstants.HRRFCliUrl);
                var request = new RestRequest(UiConstants.GetHRRFByHRRFNumber); 
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("HRRFNo", HRRFNo);
                //request.AddParameter("HRRFNo", HRRFNo, ParameterType.UrlSegment);
                var response = client.Execute(request);

                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }

            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
        public string NumberingSystem(string CompanyCode, string BranchCode, string TypeCode)
        {
            try
            {
                var client = new RestClient(UiConstants.HRRFNumberingCliUrl);
                var request = new RestRequest(UiConstants.HRRFNumberingCode);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("CompanyCode", CompanyCode);
                request.AddUrlSegment("BranchCode", BranchCode);
                request.AddUrlSegment("TypeCode", TypeCode);
                var response = client.Execute(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }

            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }

        public string Notifications(string managerid,string applicationCode)
        {
            try
            {
                var client = new RestClient(UiConstants.NotificationCliUrl);
                var request = new RestRequest(UiConstants.GetPendingNotificationsByApplication);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("managerid", managerid);
                request.AddUrlSegment("applicationCode", applicationCode);

                var response = client.Execute(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }

            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }

        public string GetNotificationsPendingForApproval(string managerid)
        {
            try
            {
                var client = new RestClient(UiConstants.NotificationCliUrl);
                var request = new RestRequest(UiConstants.GetNotificationsPendingForApproval);
                request.AddHeader("Accept", "application/json");
                request.AddUrlSegment("managerid", managerid);
                

                var response = client.Execute(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }

            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }

        public string CreateHRRF(HRRF HRRFList)
        {
            try
            {
                var client = new RestClient(UiConstants.GetLookupService);
                var request = new RestRequest(UiConstants.InsertHRRFDetails);
                request.AddHeader("Accept", "application/json");
               // request.AddUrlSegment("ID", id);
                var response = client.Execute<HRRF>(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }

        //Below code is written by Sarath
        public string GetOpportunityByNameorCode()
        {
            try
            {
                var client = new RestClient(UiConstants.GetOpportunityByNameorCode);
                var request = new RestRequest("api/oc");
                request.AddHeader("Accept", "application/json");
                //request.AddUrlSegment("CompanyCode", Opportunity);
                //request.AddUrlSegment("BranchCode", BranchCode);
                //request.AddUrlSegment("TypeCode", TypeCode);
                var response = client.Execute(request);
                //check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    ApplicationLog.Error(response.StatusDescription, response.StatusDescription);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ApplicationLog.Error(ex.ToString(), ex.ToString());
                return null;
            }
        }
    }
}
