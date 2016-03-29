#include "basicui.h"
#include "sensors.h"


/* Register the accelerometer sensor */
/* and link to the callback function */
/* Run once at the start of the app  */
/* ----------------------------------------------------------------------------*/
static int
register_accelerometer_callback(appdata_s *ad)
{

	dlog_print(DLOG_INFO, "basicui", "started");

    int error;
    bool supported;
    sensor_h *accelerometer = ad->accelerometer;
    sensor_listener_h *accelerationListener = ad->accelerationListener;

    error = sensor_is_supported( SENSOR_ACCELEROMETER, &supported );
    if(error != SENSOR_ERROR_NONE && supported){
     return error;
    }

    error = sensor_get_default_sensor(SENSOR_ACCELEROMETER, &accelerometer);
    if(error != SENSOR_ERROR_NONE){
     return error;
    }

    error = sensor_create_listener( accelerometer, &(ad->accelerationListener));
    if(error != SENSOR_ERROR_NONE){
     return error;
    }

    error = sensor_listener_set_event_cb( ad->accelerationListener,
            ACCELEROMETER_INTERVAL_MS, accelerometer_cb, ad );
    if(error != SENSOR_ERROR_NONE){
     return error;
    }

	//dlog_print(DLOG_INFO, "basicui", "listener");

    return SENSOR_ERROR_NONE;
}


/* Accelerometer callback function (called every 10MS) */
/* --------------------------------------------------- */
static void
accelerometer_cb(sensor_h sensor, sensor_event_s *event, void *data){

    appdata_s * ad = (appdata_s *)data;

    /*	Save the very first timestamp collected
    */
    if (ad->i == 1){
    	ad->start_t = event->timestamp;
    }

    /*	Acceleration for each axis:
    */
	ad->timestamp = (event->timestamp) - (ad->start_t);
    ad->aX = event->values[0];
    ad->aY = event->values[1];
    ad->aZ = event->values[2];


    /*	Purely visual => shows timestamp to user
      	 may affect performance...
    */
	// float to string formatting
	char timestamp_str[40];
	sprintf(timestamp_str, "%f",ad->timestamp);

	char * separator = "."; 	// get rid of the .0000 part (by finding ".")
	char * b = strtok(timestamp_str,separator);
	sprintf(timestamp_str,"%s\n", timestamp_str);

	// save the string as an int (solve the .0000 problem)
	//ad->timestamp = atoi(timestamp_str);
	//sprintf(timestamp_str, "%f",ad->timestamp);

	//char* time = eina_counter_dump(ad->counter);
	elm_object_text_set(ad->label, timestamp_str);


	/*	save data in the all_data array
	*/
	(ad->all_data)[ad->i][0] = ad->timestamp;
	(ad->all_data)[ad->i][1] = ad->aX;
	(ad->all_data)[ad->i][2] = ad->aY;
	(ad->all_data)[ad->i][3] = ad->aZ;

	/* increase counter */
	ad->i += 1;

}


/* Register the Gyroscope sensor */
/* and link to the callback function */
/* Run once at the start of the app  */
/* ----------------------------------------------------------------------------*/
static int
register_gyroscope_callback(appdata_s *ad)
{

	dlog_print(DLOG_INFO, "basicui", "started");

    int error;
    bool supported;
    sensor_h *gyroscope = ad->gyroscope;
    sensor_listener_h *gyroscopeListener = ad->gyroscopeListener;

    error = sensor_is_supported( SENSOR_GYROSCOPE , &supported );
    if(error != SENSOR_ERROR_NONE && supported){
     return error;
    }

    error = sensor_get_default_sensor(SENSOR_GYROSCOPE , &gyroscope);
    if(error != SENSOR_ERROR_NONE){
     return error;
    }

    error = sensor_create_listener( gyroscope, &(ad->gyroscopeListener));
    if(error != SENSOR_ERROR_NONE){
     return error;
    }

    error = sensor_listener_set_event_cb( ad->gyroscopeListener,
    		GYROSCOPE_INTERVAL_MS, gyroscope_cb, ad );
    if(error != SENSOR_ERROR_NONE){
     return error;
    }

	//dlog_print(DLOG_INFO, "basicui", "listener");

    return SENSOR_ERROR_NONE;
}

/* Gyroscope callback function (called every 10MS) */
/* --------------------------------------------------- */
static void
gyroscope_cb(sensor_h sensor, sensor_event_s *event, void *data){

    appdata_s * ad = (appdata_s *)data;

    /*	Save the very first timestamp collected
    */
    if (ad->j == 1){
    	ad->start_t_g = event->timestamp;
    }

    /*	Acceleration for each axis:
    */
	ad->timestamp_g = (event->timestamp) - (ad->start_t_g);
    ad->rX = event->values[0];
    ad->rY = event->values[1];
    ad->rZ = event->values[2];

	/*	save data in the all_data array
	*/
	(ad->all_data)[ad->j][4] = ad->timestamp_g;
	(ad->all_data)[ad->j][5] = ad->rX;
	(ad->all_data)[ad->j][6] = ad->rY;
	(ad->all_data)[ad->j][7] = ad->rZ;

	/* increase counter */
	ad->j += 1;

}

