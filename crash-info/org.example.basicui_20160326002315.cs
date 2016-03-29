S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 3253
Date: 2016-03-26 00:23:15+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x4142dec0, r1   = 0x4155edaa
r2   = 0xbec58d00, r3   = 0x00000010
r4   = 0xbec58d08, r5   = 0xbec58d00
r6   = 0x00000000, r7   = 0xbec58da4
r8   = 0xbec58ec4, r9   = 0x4004dc40
r10  = 0x4155edaa, fp   = 0xbec58cec
ip   = 0x404bb140, sp   = 0xbec58788
lr   = 0x404b1ee4, pc   = 0x404b1ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     24504 KB
Buffers:     15264 KB
Cached:     136100 KB
VmPeak:      68880 KB
VmSize:      68876 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15108 KB
VmRSS:       15104 KB
VmData:      13420 KB
VmStk:        1012 KB
VmExe:          20 KB
VmLib:       22740 KB
VmPTE:          44 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3253 TID = 3253
3253 3271 

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
436c4000 43ec3000 rwxp [stack:3271]
bec4e000 bed44000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3253)
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
+0100 W/W_HOME  (  681): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
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
03-26 00:23:12.520+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11032016261731458948192
03-26 00:23:12.910+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3201
03-26 00:23:13.150+0100 E/RESOURCED( 1012): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
03-26 00:23:13.150+0100 E/AUL     ( 1012): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
03-26 00:23:13.150+0100 E/CAPI_APPFW_APP_MANAGER( 1012): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
03-26 00:23:13.315+0100 E/AUL_PAD ( 1131): launchpad.c: main(854) > Refused candidate process connection
03-26 00:23:13.320+0100 I/efl-extension( 3202): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:13.385+0100 I/MALI    ( 3202): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:13.385+0100 I/MALI    ( 3202): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3202   close drm_fd=21 
03-26 00:23:13.385+0100 I/MALI    ( 3202): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:13.485+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3202
03-26 00:23:13.820+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:13.820+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=895610 button=1 downs=1
03-26 00:23:13.820+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [171, 207]
03-26 00:23:13.915+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=895697 button=1 downs=0
03-26 00:23:13.915+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [171, 207]->[175, 205]
03-26 00:23:13.915+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:13.920+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:13.920+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:13.925+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:13.925+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:13.925+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:13.935+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:13.935+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
03-26 00:23:13.935+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:13.935+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
03-26 00:23:13.935+0100 W/AUL_AMD (  491): amd_launch.c: start_process(580) > child process: 3261
03-26 00:23:13.935+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:13.940+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:13.985+0100 W/AUL_AMD (  491): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3261
03-26 00:23:13.990+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:13.990+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:14.035+0100 I/efl-extension( 3261): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:14.065+0100 I/CAPI_APPFW_APPLICATION( 3261): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:14.115+0100 I/UXT     ( 3261): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:14.330+0100 I/CAPI_APPFW_APPLICATION( 3261): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:14.385+0100 E/TBM     ( 3261): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:14.390+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:23:14.395+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3261
03-26 00:23:14.400+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:23:14.535+0100 E/EFL     ( 3261): ecore_evas<3261> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:14.725+0100 I/AUL_PAD ( 3253): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 23
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3261
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __send_app_termination_signal(511) > send dead signal done
03-26 00:23:15.075+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3261
03-26 00:23:15.510+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:15.515+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=897301 button=1 downs=1
03-26 00:23:15.515+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [178, 192]
03-26 00:23:15.625+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=897410 button=1 downs=0
03-26 00:23:15.625+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [178, 192]->[155, 189]
03-26 00:23:15.630+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:15.630+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:15.630+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:15.635+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:15.635+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:15.635+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:15.645+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:15.645+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:23:15.650+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:15.655+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:15.655+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:15.695+0100 I/efl-extension( 3253): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:15.695+0100 I/UXT     ( 3253): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:15.700+0100 I/CAPI_APPFW_APPLICATION( 3253): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:15.705+0100 I/CAPI_APPFW_APPLICATION( 3253): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:15.750+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:15.750+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:15.750+0100 E/TBM     ( 3253): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:15.810+0100 E/EFL     ( 3253): ecore_evas<3253> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:16.115+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:16.390+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3253
03-26 00:23:16.720+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:16.770+0100 E/RESOURCED( 1012): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
03-26 00:23:16.770+0100 E/AUL     ( 1012): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
03-26 00:23:16.770+0100 E/CAPI_APPFW_APP_MANAGER( 1012): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
03-26 00:23:17.330+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:17.330+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=899119 button=1 downs=1
03-26 00:23:17.330+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [157, 188]
03-26 00:23:17.415+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=899195 button=1 downs=0
03-26 00:23:17.415+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [157, 188]->[149, 184]
03-26 00:23:17.415+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:17.415+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:17.415+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:17.415+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:17.415+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:17.415+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:17.430+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:17.430+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:17.430+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:17.435+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
03-26 00:23:17.435+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:17.435+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
03-26 00:23:17.435+0100 W/AUL_AMD (  491): amd_launch.c: start_process(580) > child process: 3275
03-26 00:23:17.485+0100 W/AUL_AMD (  491): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3275
03-26 00:23:17.485+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:17.490+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:17.580+0100 I/efl-extension( 3275): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:17.625+0100 I/CAPI_APPFW_APPLICATION( 3275): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:17.695+0100 I/UXT     ( 3275): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:17.775+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:23:17.785+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3275
03-26 00:23:17.785+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:23:17.890+0100 I/CAPI_APPFW_APPLICATION( 3275): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:17.960+0100 E/TBM     ( 3275): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:18.135+0100 E/EFL     ( 3275): ecore_evas<3275> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:18.150+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
03-26 00:23:18.150+0100 I/WATCH_CORE(  702): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
03-26 00:23:18.150+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:23:18.170+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
03-26 00:23:18.170+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
03-26 00:23:18.170+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
03-26 00:23:18.170+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
03-26 00:23:18.175+0100 W/W_HOME  (  681): dbus.c: _dbus_message_recv_cb(204) > LCD off
03-26 00:23:18.175+0100 W/W_HOME  (  681): gesture.c: _manual_render_disable_timer_del(151) > timer del
03-26 00:23:18.175+0100 W/W_HOME  (  681): gesture.c: _manual_render_enable(133) > 1
03-26 00:23:18.175+0100 W/W_HOME  (  681): event_manager.c: _lcd_off_cb(699) > lcd state: 0
03-26 00:23:18.175+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
03-26 00:23:18.175+0100 E/STARTER (  657): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
03-26 00:23:18.180+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
03-26 00:23:18.235+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
03-26 00:23:18.235+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-26 00:23:18.235+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
03-26 00:23:18.235+0100 I/HIGEAR  ( 1058): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
03-26 00:23:18.315+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:780]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
03-26 00:23:18.325+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: PAUSE State: RUNNING
03-26 00:23:18.325+0100 I/CAPI_APPFW_APPLICATION(  681): app_main.c: app_appcore_pause(202) > app_appcore_pause
03-26 00:23:18.325+0100 W/W_HOME  (  681): main.c: _appcore_pause_cb(690) > appcore pause
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.325+0100 W/W_HOME  (  681): rotary.c: rotary_deattach(156) > rotary_deattach:0x477b5668
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x477b5668, elm_layout, func : 0x4004b359
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45b58d58, elm_box, _activated_obj : 0x477b5668, activated : 1
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:23:18.325+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:23:18.325+0100 I/wnotib  (  681): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 1, 202.
03-26 00:23:18.325+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:18.340+0100 E/ALARM_MANAGER(  657): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(26-3-2016, 00:23:38), repeat(1), interval(20), type(-1073741822)
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:18.345+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:23:18.345+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [false][0m
03-26 00:23:18.345+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:18.345+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:23:18.350+0100 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
03-26 00:23:18.350+0100 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
03-26 00:23:18.400+0100 I/SHealth_Common( 1012): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
03-26 00:23:18.400+0100 I/SHealth_Service( 1012): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1861371125, next duetime: 1458948218
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1861371125)
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1458981420), due_time(1458948218)
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 25-3-2016, 23:23:38 (UTC).
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
03-26 00:23:18.615+0100 W/APPS    (  681): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
03-26 00:23:18.715+0100 I/AUL_PAD ( 3274): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:18.845+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: MEM_FLUSH State: PAUSED
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 23
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3275
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __send_app_termination_signal(511) > send dead signal done
03-26 00:23:18.905+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3275
03-26 00:23:21.200+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11032616261731458948194
03-26 00:23:23.350+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: MEM_FLUSH State: PAUSED
03-26 00:23:29.255+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1103253626173145894819
