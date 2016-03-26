#include "basicui.h"

// -------------------------------
// --------------------------------
//---------------------------------

#define ACCELEROMETER_INTERVAL_MS 20

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
/*
static void get_current_datetime( char *datetime){
	// pass variable => char datetime = "";
	// as => get_current_datetime( &datetime);
	time_t rawtime;
	struct tm * timeinfo;
	time (&rawtime);
	timeinfo = localtime (&rawtime);
	sprintf(datetime, "%s", asctime(timeinfo));
}*/

static void
accelerometer_cb(sensor_h sensor, sensor_event_s *event, void *data){

    appdata_s * ad = (appdata_s *)data;

    /*
        Acceleration for each axis:
        	(float)event->values[0]
        	(float)event->values[1]
        	(float)event->values[2]
    */

    // save current time
    /*ad->sys_time = get_current_datetime();*/


	ad->timestamp = event->timestamp;
    ad->aX = event->values[0];
    ad->aY = event->values[1];
    ad->aZ = event->values[2];

    /*
	char aX_str[10];
	sprintf (aX_str, "%f", ad->aX);*/


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

	// save data in the all_data array
	(ad->all_data)[ad->i][0] = ad->timestamp;
	(ad->all_data)[ad->i][1] = ad->aX;
	(ad->all_data)[ad->i][2] = ad->aY;
	(ad->all_data)[ad->i][3] = ad->aZ;
	//(ad->all_data)[ad->i][4] = ad->timestamp;
	//(ad->all_data)[ad->i][5] = ad->timestamp;
	//(ad->all_data)[ad->i][6] = ad->timestamp;

	ad->i += 1;

}


//---------------------------------
//---------------------------------
//---------------------------------

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}
/*
static char format_time(float time, char time_str){
	sprintf(time_str, "%f",time);
	char * separator = ".";
	char * b = strtok(time_str,separator);
	sprintf(time_str,"%s\n", time_str);
}*/

/*
static void save_data(){
	//int filename_l = 30;
	//int cell_size = 20;

	FILE * write_file;              	// pointer to file you will write to
	//char filename[filename_l];     		// variable to hold the name of file
	//char cell[cell_size];        		// buffer to hold your text
	char *dir = app_get_data_path();
	char filename = "data.json";
	strcat(filename, dir);

	char cell = "[data]";
	dlog_print(DLOG_DEBUG, LOG_TAG, filename);

	write_file = fopen(filename, "ab+");    // create/overwrite file user named

	if (!write_file) {dlog_print(DLOG_DEBUG, LOG_TAG, "Fail to get file");} // failed to create FILE *

	// while getting input, print to file
	fputs(cell, write_file);
	fclose(write_file);
}*/

static void save_data(void *data){

	appdata_s *ad = (appdata_s*)data;

	// This is to delete all the previous files
	//system("exec rm -r /opt/usr/media/Documents/*");

	char filename[50];
	time_t t = time(NULL);
	struct tm tm = *localtime(&t);
	sprintf(filename, "/opt/usr/media/Downloads/data-%d-%d-%d_%d-%d-%d.txt", tm.tm_year + 1900, tm.tm_mon + 1, tm.tm_mday, tm.tm_hour, tm.tm_min, tm.tm_sec);
	ad->fp = fopen (filename, "w+");
	fprintf(ad->fp, "%s\n", "it f****** worked!");
	fclose(ad->fp);
}

static void nothing(){

	int x = 12;
}

static void _button_click_cb(void *data, Evas_Object *button, void *ev)
{
	appdata_s *ad = data;

	if ( strcmp(elm_object_part_text_get(button, NULL), "Start") == 0 ){ // compare button string and "Start"

		/* Start the accelerometer and data collection */
		/* --------------------------------------------*/

		// reset data start accelerometer
		ad->i = 0;
		memset(ad->all_data, 0.0f, sizeof(ad->all_data));

		// capture current time
		time_t rawtime;
		struct tm * timeinfo;
		time (&rawtime);
		timeinfo = localtime (&rawtime);
		sprintf(ad->sys_time, "%s", asctime(timeinfo));

		//start accelerometer
	    int error = sensor_listener_start(ad->accelerationListener );

		// save starting time + change button value
		elm_object_text_set(button,"Stop");
		ad->start_t = ad->timestamp;

		// float to string formatting
		char timestamp_str[20];
		sprintf(timestamp_str, "%f",ad->start_t);
		char * separator = ".";
		char * b = strtok(timestamp_str,separator);
		sprintf(timestamp_str,"%s\n", timestamp_str);

		// print out value on screen
		elm_object_text_set(ad->label2, timestamp_str);

   } else {
	   /* Data Collection stops => save data in file */
	   /* ------------------------------------------ */

	   int error = sensor_listener_stop(ad->accelerationListener); // unset the sensor callback function

	   // change button and label value
	   elm_object_text_set(button,"Start");
	   elm_object_text_set(ad->label2, "00:00");

	   save_data(ad); // save data into file
	   //nothing();
   }
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* ----------------------------------------------------------------------------- */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* -------------------------------- */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* NaviFrame */
	/* -------------------------------- */
	ad->nf = elm_naviframe_add(ad->conform);
	elm_object_content_set(ad->conform, ad->nf);
	evas_object_show(ad->nf);

	/* Box */
	/* -------------------------------- */
	ad->box = elm_box_add(ad->nf);
	evas_object_show(ad->box);

	// push box to naviframe
	elm_naviframe_item_push(ad->nf, _("Accelerometer"), NULL, NULL, ad->box, "basic");


	/* Label */
	/* -------------------------------- */
	ad->label = elm_label_add(ad->box);
	elm_object_text_set(ad->label,"<align=center>00.00</align><br/>");
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	// ---- elm_object_content_set(ad->box, ad->label);
	elm_box_pack_end(ad->box, ad->label);				// Add the label to the box
	evas_object_show(ad->label);						// Change label visibility

	/* Label 2 */
	/* -------------------------------- */
	ad->label2 = elm_label_add(ad->box);
	elm_object_text_set(ad->label2,"<align=center>time1</align><br/>");
	evas_object_size_hint_weight_set(ad->label2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	// ---- elm_object_content_set(ad->box, ad->label);
	elm_box_pack_end(ad->box, ad->label2);				// Add the label to the box
	evas_object_show(ad->label2);						// Change label visibility

	/* Start Button */
	/* -------------------------------- */
	ad->button = elm_button_add(ad->box);
	elm_object_text_set(ad->button,"Start");
	evas_object_size_hint_weight_set(ad->button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->button, EVAS_HINT_FILL, 0.0);
	elm_box_pack_end(ad->box, ad->button);
	evas_object_show(ad->button);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);


	//test
	//save_data(ad);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	// create GUI + register accelerometer
	create_base_gui(ad);
	register_accelerometer_callback(ad);

	// Start button "clicked" => start timer and data gatheringh
	evas_object_smart_callback_add(ad->button, "clicked", _button_click_cb, ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);



	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}


	return ret;
}
