S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 3201
Date: 2016-03-26 00:23:12+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x4142dec0, r1   = 0x4155edaa
r2   = 0xbed34d00, r3   = 0x00000010
r4   = 0xbed34d08, r5   = 0xbed34d00
r6   = 0x00000000, r7   = 0xbed34da4
r8   = 0xbed34ec4, r9   = 0x4004dc40
r10  = 0x4155edaa, fp   = 0xbed34cec
ip   = 0x404bb140, sp   = 0xbed34788
lr   = 0x404b1ee4, pc   = 0x404b1ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     22852 KB
Buffers:     15140 KB
Cached:     134996 KB
VmPeak:      68880 KB
VmSize:      68876 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15112 KB
VmRSS:       15108 KB
VmData:      13420 KB
VmStk:        1012 KB
VmExe:          20 KB
VmLib:       22740 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3201 TID = 3201
3201 3239 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41530000 41534000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4153c000 41544000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
4155d000 4155f000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
41568000 41569000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41971000 41975000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
4197e000 4199f000 r-xp /usr/lib/libefl-extension.so.0.1.0
419a7000 419c5000 r-xp /usr/lib/libsensor.so.1.1.0
419cf000 419e1000 r-xp /usr/lib/libefl-assist.so.0.1.0
419e9000 41aa1000 r-xp /usr/lib/libcairo.so.2.11200.14
41aac000 41ab3000 r-xp /usr/lib/libsensord-share.so
41abb000 41acd000 r-xp /usr/lib/libtts.so
41ad5000 41af6000 r-xp /usr/lib/libui-extension.so.0.1.0
41aff000 41b06000 r-xp /usr/lib/libtbm.so.1.0.0
41b0e000 41b1c000 r-xp /usr/lib/libGLESv2.so.2.0
41b25000 41b2b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b33000 41b36000 r-xp /usr/lib/libEGL.so.1.4
41b3e000 41b43000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b4b000 41c88000 r-xp /usr/lib/libicui18n.so.51.1
41c98000 41d7c000 r-xp /usr/lib/libicuuc.so.51.1
41d91000 41d94000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d9c000 41da4000 r-xp /usr/lib/libdrm.so.2.4.0
43333000 43338000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43341000 43346000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4334e000 43350000 r-xp /usr/lib/libdri2.so.0.0.0
43358000 43379000 r-xp /usr/lib/libexif.so.12.3.3
4338c000 43391000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43399000 43463000 r-xp /usr/lib/libCOREGL.so.4.0
43675000 43680000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43689000 4368d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43695000 436ac000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
436b9000 436bb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
436c4000 43ec3000 rwxp [stack:3239]
bed2a000 bee20000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3201)
Call Stack Count: 3
 0: _IO_vfprintf + 0x20 (0x404b1ee4) [/lib/libc.so.6] + 0x3cee4
 1: _IO_fprintf + 0x1c (0x404bb15c) [/lib/libc.so.6] + 0x4615c
 2: save_data + 0xc0 (0x4155eb55) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1b55
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
3203): wc-popup-view.c: _create_window(1653) > windows size - 360:360
03-26 00:23:03.425+0100 E/UXT     ( 3203): uxt_theme.c: uxt_theme_add_color_table(507) > failed to get table
03-26 00:23:03.425+0100 E/UXT     ( 3203): uxt_theme.c: uxt_theme_set_font_table(1136) > failed to get font table.
03-26 00:23:03.435+0100 W/WC_POPUP( 3203): wc-popup-view.c: _create_connect_popup(1464) > disconnected_manually : 0
03-26 00:23:03.435+0100 W/WC_POPUP( 3203): wc-popup-view.c: _create_connect_popup(1465) > remote_enabled : 0
03-26 00:23:03.435+0100 W/WC_POPUP( 3203): wc-popup-view.c: _create_connect_popup(1469) > disabled remote connection
03-26 00:23:03.560+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:23:03.570+0100 I/efl-extension( 3203): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44d42558 = w: 0 h: 0  obj 0x44d4f170 w: 360 h: 360
03-26 00:23:03.575+0100 I/efl-extension( 3203): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
03-26 00:23:03.580+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
03-26 00:23:03.580+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
03-26 00:23:03.580+0100 I/efl-extension( 3203): efl_extension_rotary.c: _init_Xi2_system(314) > In
03-26 00:23:03.580+0100 I/efl-extension( 3203): efl_extension_rotary.c: _init_Xi2_system(375) > Done
03-26 00:23:03.605+0100 I/WC_POPUP( 3203): wc-popup-view.c: __add_button(212) > 
03-26 00:23:03.615+0100 E/GESTURE (  138): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=38   flick_area=55 ---> SET value to 1
03-26 00:23:03.615+0100 E/GESTURE (  138): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
03-26 00:23:03.615+0100 E/GESTURE (  138): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=38   flick_area=55 ---> SET value to 1
03-26 00:23:03.755+0100 E/UXT     ( 3203): uxt_theme_object.c: uxt_theme_object_set_color(407) > failed to get color for code(AXO001P)
03-26 00:23:03.790+0100 E/GESTURE (  138): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
03-26 00:23:03.805+0100 W/AUL_AMD (  491): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
03-26 00:23:03.805+0100 W/AUL_AMD (  491): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
03-26 00:23:03.850+0100 E/UXT     ( 3203): uxt_theme_object.c: uxt_theme_object_set_color(407) > failed to get color for code(AXO001P)
03-26 00:23:03.860+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44ad6390, elm_scroller, _activated_obj : 0x0, activated : 1
03-26 00:23:03.925+0100 W/PROCESSMGR(  440): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
03-26 00:23:03.935+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
03-26 00:23:03.935+0100 I/WATCH_CORE(  702): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
03-26 00:23:03.935+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:23:03.985+0100 W/W_HOME  (  681): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
03-26 00:23:03.985+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:03.985+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:03.985+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:03.985+0100 W/W_HOME  (  681): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.000+0100 W/W_HOME  (  681): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
03-26 00:23:04.000+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: RESUME State: PAUSED
03-26 00:23:04.000+0100 I/CAPI_APPFW_APPLICATION(  681): app_main.c: app_appcore_resume(223) > app_appcore_resume
03-26 00:23:04.000+0100 W/W_HOME  (  681): main.c: _appcore_resume_cb(681) > appcore resume
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.000+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.000+0100 W/APPS    (  681): apps_main.c: _time_changed_cb(295) >  date : 26->26
03-26 00:23:04.000+0100 W/W_HOME  (  681): rotary.c: rotary_attach(138) > rotary_attach:0x477b5668
03-26 00:23:04.000+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x477b5668, elm_layout, _activated_obj : 0x45b58d58, activated : 1
03-26 00:23:04.000+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:23:04.000+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
03-26 00:23:04.000+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:23:04.000+0100 W/wnotib  (  681): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
03-26 00:23:04.010+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:23:04.010+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:04.010+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:04.010+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:04.010+0100 I/APP_CORE( 3161): appcore-efl.c: __do_app(429) > [APP 3161] Event: PAUSE State: RUNNING
03-26 00:23:04.010+0100 I/CAPI_APPFW_APPLICATION( 3161): app_main.c: app_appcore_pause(202) > app_appcore_pause
03-26 00:23:04.010+0100 W/WFMD    ( 3161): wfmd-main.c: app_pause(1306) > 
03-26 00:23:04.015+0100 W/WFMD    ( 3161): wfmd-main.c: wfmd_send_app_message_to_consumer(1548) > app message [-1] -> [3]
03-26 00:23:04.015+0100 W/FMP-SERVICE( 3161): fmp-consumer.c: fmp_consumer_send(1242) > ## APP SEND TYPE : 4
03-26 00:23:04.015+0100 W/FMP-SERVICE( 3161): fmp-consumer.c: fmp_consumer_send(1245) > fmp consumer is not initialized
03-26 00:23:04.025+0100 I/APP_CORE( 3203): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
03-26 00:23:04.025+0100 I/APP_CORE( 3203): appcore-efl.c: __do_app(474) > [APP 3203] Initial Launching, call the resume_cb
03-26 00:23:04.025+0100 I/CAPI_APPFW_APPLICATION( 3203): app_main.c: app_appcore_resume(223) > app_appcore_resume
03-26 00:23:04.025+0100 I/WC_POPUP( 3203): main.c: app_resume(266) > 
03-26 00:23:04.030+0100 E/E17     (  440): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x07600008)
03-26 00:23:04.055+0100 W/W_HOME  (  681): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
03-26 00:23:04.055+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.055+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.055+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:04.055+0100 W/W_HOME  (  681): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
03-26 00:23:04.060+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:04.060+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:23:04.070+0100 W/APP_CORE( 3203): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7600008
03-26 00:23:04.225+0100 W/AUL_AMD (  491): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
03-26 00:23:04.225+0100 W/AUL_AMD (  491): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
03-26 00:23:04.240+0100 I/APP_CORE( 3203): appcore-efl.c: __do_app(429) > [APP 3203] Event: RESUME State: RUNNING
03-26 00:23:04.975+0100 I/RESOURCED(  492): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 21 -> 20 1458948184 331
03-26 00:23:04.975+0100 I/RESOURCED(  492): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 20 1371 83 457
03-26 00:23:04.975+0100 I/RESOURCED(  492): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 20 0 0 278
03-26 00:23:04.975+0100 I/RESOURCED(  492): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 20 545 62 182
03-26 00:23:04.975+0100 I/RESOURCED(  492): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 20 196 5 65
03-26 00:23:04.975+0100 I/RESOURCED(  492): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 20 494 26 165
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.000+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:23:05.005+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.005+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:23:05.005+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [true][0m
03-26 00:23:05.005+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:23:05.010+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 681
03-26 00:23:05.050+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.050+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.055+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:23:05.055+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:23:05.055+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.055+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:23:05.055+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:23:05.055+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:23:05.060+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:23:05.060+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:05.315+0100 I/APP_CORE( 3124): appcore-efl.c: __do_app(429) > [APP 3124] Event: MEM_FLUSH State: PAUSED
03-26 00:23:06.045+0100 E/EFL     ( 3203): evas_main<3203> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=887837 button=1 downs=1
03-26 00:23:06.090+0100 E/EFL     ( 3203): evas_main<3203> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=887870 button=1 downs=0
03-26 00:23:06.140+0100 I/WC_POPUP( 3203): wc-popup-view.c: __send_user_resp(120) > result[CANCEL]
03-26 00:23:06.155+0100 I/WC_POPUP( 3203): wc-popup-view.c: __send_user_resp(127) > Service reply success
03-26 00:23:06.155+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 6
03-26 00:23:06.155+0100 E/CAPI_APPFW_APP_CONTROL( 3203): app_control.c: app_control_error(138) > [app_control_destroy] INVALID_PARAMETER(0xffffffea)
03-26 00:23:06.155+0100 I/WC_POPUP( 3203): wc-popup-view.c: __remove_appdata(180) > 
03-26 00:23:06.155+0100 W/AUL_AMD (  491): amd_request.c: __foward_cmd(153) > __forward_cmd: 3203 3203
03-26 00:23:06.160+0100 W/PROCESSMGR(  440): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
03-26 00:23:06.165+0100 I/CAPI_APPFW_APP_CONTROL( 3161): app_control.c: app_control_request_result_broker(187) > app_control_request_result_broker, result: 0
03-26 00:23:06.165+0100 W/W_HOME  (  681): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
03-26 00:23:06.165+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:06.165+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:06.165+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:06.165+0100 W/W_HOME  (  681): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
03-26 00:23:06.165+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:23:06.165+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:06.190+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
03-26 00:23:06.190+0100 I/WATCH_CORE(  702): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
03-26 00:23:06.190+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:23:06.200+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 22
03-26 00:23:06.200+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(890) > app status : 4
03-26 00:23:06.205+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44ad6390, elm_scroller, _activated_obj : 0x44ad6390, activated : 0
03-26 00:23:06.215+0100 I/MALI    (  681): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442d1618] swap changed from async to sync
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44ad6390, obj: 0x44ad6390
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _object_deleted_cb(601) > done
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44d42558 is freed
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44ad6390, elm_scroller, func : 0x411bcef1
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44d4f170, elm_image, func : 0x411bcef1
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44ad6390 : elm_scroller] rotary callabck is deleted
03-26 00:23:06.255+0100 I/MALI    ( 3203): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:06.255+0100 I/MALI    ( 3203): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3203   close drm_fd=27 
03-26 00:23:06.255+0100 I/MALI    ( 3203): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:06.270+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 22
03-26 00:23:06.270+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(890) > app status : 4
03-26 00:23:06.270+0100 E/APP_CORE( 3203): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
03-26 00:23:06.270+0100 I/APP_CORE( 3203): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
03-26 00:23:06.270+0100 I/APP_CORE( 3203): appcore-efl.c: __after_loop(1090) > [APP 3203] PAUSE before termination
03-26 00:23:06.270+0100 I/CAPI_APPFW_APPLICATION( 3203): app_main.c: app_appcore_pause(202) > app_appcore_pause
03-26 00:23:06.270+0100 I/WC_POPUP( 3203): main.c: app_pause(261) > 
03-26 00:23:06.270+0100 I/CAPI_APPFW_APPLICATION( 3203): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
03-26 00:23:06.270+0100 I/WC_POPUP( 3203): main.c: app_terminate(172) > 
03-26 00:23:06.275+0100 W/WC_POPUP( 3203): bt-connection-handler.c: _bt_deinit(288) > bt_deinitialize already done
03-26 00:23:06.330+0100 I/UXT     ( 3203): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
03-26 00:23:06.475+0100 E/APP_CORE( 3161): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
03-26 00:23:06.475+0100 I/APP_CORE( 3161): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
03-26 00:23:06.475+0100 I/CAPI_APPFW_APPLICATION( 3161): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
03-26 00:23:06.475+0100 W/WFMD    ( 3161): wfmd-main.c: app_terminate(1255) > 
03-26 00:23:06.475+0100 E/WFMD    ( 3161): wfmd-main.c: _wfmd_network_status_callback_set(701) > vconf_ignore_key_changed error : [-1]
03-26 00:23:06.475+0100 E/WFMD    ( 3161): wfmd-main.c: _wfmd_network_status_callback_set(707) > vconf_ignore_key_changed error : [-1]
03-26 00:23:06.490+0100 I/AUL_PAD ( 3201): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:06.620+0100 I/efl-extension( 3203): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 23
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3203
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __send_app_termination_signal(511) > send dead signal done
03-26 00:23:06.775+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3203
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x441fd208, obj: 0x441fd208
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _object_deleted_cb(601) > done
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x442a98e8
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x441fd208, elm_scroller, func : 0x419a0ef1
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x442a98e8, elm_image, func : 0x419a0ef1
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x441fd208 : elm_scroller] rotary callabck is deleted
03-26 00:23:06.855+0100 I/MALI    ( 3161): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:06.855+0100 I/MALI    ( 3161): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3161   close drm_fd=25 
03-26 00:23:06.855+0100 I/MALI    ( 3161): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:06.965+0100 I/UXT     ( 3161): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
03-26 00:23:07.230+0100 I/efl-extension( 3161): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:07.285+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:07.285+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=889076 button=1 downs=1
03-26 00:23:07.285+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [255, 83]
03-26 00:23:07.405+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3161
03-26 00:23:07.470+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=889261 button=1 downs=0
03-26 00:23:07.470+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [255, 83]->[238, 73]
03-26 00:23:07.470+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:07.470+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
03-26 00:23:07.510+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxBackwardAnimation(3604) >  (!__pEmptyBox) -> runEmptyBoxBackwardAnimation() return
03-26 00:23:07.740+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:08.115+0100 I/efl-extension( 3202): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:08.200+0100 W/AUL_AMD (  491): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
03-26 00:23:08.270+0100 W/AUL_AMD (  491): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
03-26 00:23:08.330+0100 I/UXT     ( 3202): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:08.345+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:08.345+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=890137 button=1 downs=1
03-26 00:23:08.350+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [113, 79]
03-26 00:23:08.445+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=890235 button=1 downs=0
03-26 00:23:08.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [113, 79]->[118, 81]
03-26 00:23:08.445+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:08.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:23:08.455+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:23:08.690+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:08.995+0100 E/SHealth_Common( 1012): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
03-26 00:23:09.115+0100 E/AUL_PAD ( 1131): launchpad.c: main(854) > Refused candidate process connection
03-26 00:23:09.130+0100 I/efl-extension( 3168): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:09.230+0100 I/MALI    ( 3168): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:09.230+0100 I/MALI    ( 3168): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3168   close drm_fd=22 
03-26 00:23:09.230+0100 I/MALI    ( 3168): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:09.260+0100 I/AUL_PAD ( 3202): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:09.400+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3168
03-26 00:23:09.490+0100 E/TBM     ( 3202): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:09.495+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.495+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891286
03-26 00:23:09.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
03-26 00:23:09.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[16], __pAppsItemList.size[23]
03-26 00:23:09.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[17]
03-26 00:23:09.495+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.495+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.580+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.580+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.580+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891369
03-26 00:23:09.580+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[17], __pAppsItemList.size[23]
03-26 00:23:09.580+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
03-26 00:23:09.585+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:09.595+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.780+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.780+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.780+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891569
03-26 00:23:09.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[18], __pAppsItemList.size[23]
03-26 00:23:09.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
03-26 00:23:09.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:09.785+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.950+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.950+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.955+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.955+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891735
03-26 00:23:09.955+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[19], __pAppsItemList.size[23]
03-26 00:23:09.955+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[20]
03-26 00:23:09.960+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:10.185+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:10.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.445+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 892236
03-26 00:23:10.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[20], __pAppsItemList.size[23]
03-26 00:23:10.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:23:10.445+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.680+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.680+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.685+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.685+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 892472
03-26 00:23:10.685+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[21], __pAppsItemList.size[23]
03-26 00:23:10.685+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[22]
03-26 00:23:10.685+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:10.915+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:11.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:23:11.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 893052
03-26 00:23:11.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[22], __pAppsItemList.size[23]
03-26 00:23:11.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:23:11.265+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:23:11.275+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:23:11.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:11.960+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:11.960+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=893752 button=1 downs=1
03-26 00:23:11.965+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [167, 174]
03-26 00:23:12.020+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=893805 button=1 downs=0
03-26 00:23:12.020+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [167, 174]->[167, 176]
03-26 00:23:12.025+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:12.025+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:12.025+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:12.030+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:12.030+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:12.030+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:12.040+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:12.040+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:23:12.040+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:12.040+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:12.040+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:12.075+0100 I/efl-extension( 3201): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:12.075+0100 I/UXT     ( 3201): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:12.080+0100 I/CAPI_APPFW_APPLICATION( 3201): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:12.085+0100 I/CAPI_APPFW_APPLICATION( 3201): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:12.145+0100 E/TBM     ( 3201): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:12.145+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:12.150+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:12.250+0100 E/EFL     ( 3201): ecore_evas<3201> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:12.520+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1103201626173145894819
