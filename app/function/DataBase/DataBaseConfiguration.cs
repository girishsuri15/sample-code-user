using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class DataBaseConfiguration
{

    public static Dictionary<string, DataBaseInformation> countryDict = new Dictionary<string, DataBaseInformation>
    {
        {"USA" ,new DataBaseInformation(DATABASE_TYPE.SQL,"ConectionStringfromENV")},
        {"UK" ,new DataBaseInformation(DATABASE_TYPE.SQL,"ConectionStringfromENV")},
        {"default" ,new DataBaseInformation(DATABASE_TYPE.SQL,"ConectionStringfromENV")}
    };
    public static DataBaseInformation GetDataBaseInformation(string country)
    {

        DataBaseInformation value;
        if (countryDict.TryGetValue(country, out value))
        {
            return value;
        }
        else
        {
            // make sure the default always exist in the dictory of the database
            return countryDict["default"];
        }

    }


}