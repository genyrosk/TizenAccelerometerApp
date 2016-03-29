S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 2966
Date: 2016-03-26 00:22:14+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x4142dec0, r1   = 0x4155edaa
r2   = 0xbedcad00, r3   = 0x00000010
r4   = 0xbedcad08, r5   = 0xbedcad00
r6   = 0x00000000, r7   = 0xbedcada4
r8   = 0xbedcaec4, r9   = 0x4004dc40
r10  = 0x4155edaa, fp   = 0xbedcacec
ip   = 0x404bb140, sp   = 0xbedca788
lr   = 0x404b1ee4, pc   = 0x404b1ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     10752 KB
Buffers:     16116 KB
Cached:     172244 KB
VmPeak:      69408 KB
VmSize:      69404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15128 KB
VmRSS:       15124 KB
VmData:      13948 KB
VmStk:        1012 KB
VmExe:          20 KB
VmLib:       22740 KB
VmPTE:          46 KB
VmSwap:          0 KB

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
bedc0000 beeb6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2966)
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
531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
03-26 00:22:06.635+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
03-26 00:22:06.675+0100 W/W_HOME  (  681): gesture.c: _widget_updated_cb(190) > widget updated
03-26 00:22:06.675+0100 W/W_HOME  (  681): gesture.c: _manual_render_disable_timer_del(151) > timer del
03-26 00:22:06.675+0100 W/W_HOME  (  681): gesture.c: _manual_render(176) > 
03-26 00:22:06.685+0100 W/W_HOME  (  681): gesture.c: _manual_render(176) > 
03-26 00:22:06.765+0100 W/W_HOME  (  681): gesture.c: _manual_render_enable(133) > 0
03-26 00:22:06.795+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
03-26 00:22:06.795+0100 E/WMS     (  488): wms_msg_broker.c: wms_msg_broker_send(1743) > 
03-26 00:22:06.795+0100 E/WMS     (  488): ==========
03-26 00:22:06.795+0100 E/WMS     (  488): ##WMS SEND : mgr_gear_wear_onoff_req
03-26 00:22:06.795+0100 E/WMS     (  488): ==========
03-26 00:22:06.795+0100 E/WMS     (  488): wms_msg_broker.c: wms_msg_broker_send(1746) > No service connection to host. Skipping this message.
03-26 00:22:06.915+0100 I/SHealth_Common( 1012): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
03-26 00:22:06.915+0100 I/SHealth_Service( 1012): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
03-26 00:22:06.995+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:22:07.030+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
03-26 00:22:07.030+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-26 00:22:07.030+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
03-26 00:22:07.030+0100 I/HIGEAR  ( 1058): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
03-26 00:22:07.030+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
03-26 00:22:07.030+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
03-26 00:22:07.030+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
03-26 00:22:07.030+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
03-26 00:22:07.030+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
03-26 00:22:07.030+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
03-26 00:22:07.035+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
03-26 00:22:07.035+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-26 00:22:07.035+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
03-26 00:22:07.035+0100 I/HIGEAR  ( 1058): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
03-26 00:22:07.110+0100 W/SHealth_Service( 1012): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
03-26 00:22:07.110+0100 E/SHealth_Service( 1012): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
03-26 00:22:07.110+0100 E/SHealth_Common( 1012): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.550+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:22:07.550+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [true][0m
03-26 00:22:07.550+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:22:07.555+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 681
03-26 00:22:07.560+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.560+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:22:07.565+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:22:07.570+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:22:07.570+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:22:07.995+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:22:08.855+0100 E/SHealth_Common( 1012): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
03-26 00:22:08.995+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
03-26 00:22:09.230+0100 W/STARTER (  657): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
03-26 00:22:09.480+0100 W/STARTER (  657): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[1]
03-26 00:22:09.480+0100 W/STARTER (  657): hw_key.c: _powerkey_timer_cb(963) > [_powerkey_timer_cb:963] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
03-26 00:22:09.485+0100 E/STARTER (  657): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
03-26 00:22:09.490+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:09.490+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 657
03-26 00:22:09.495+0100 W/AUL_AMD (  491): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 681
03-26 00:22:09.500+0100 W/AUL_AMD (  491): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(681), cmd(0)
03-26 00:22:09.500+0100 E/AUL     (  657): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:09.500+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: RESET State: RUNNING
03-26 00:22:09.500+0100 I/CAPI_APPFW_APPLICATION(  681): app_main.c: app_appcore_reset(245) > app_appcore_reset
03-26 00:22:09.500+0100 W/W_HOME  (  681): main.c: _app_control(1726) > Service value : powerkey
03-26 00:22:09.500+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x40001
03-26 00:22:09.500+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.500+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.500+0100 W/W_HOME  (  681): noti_broker.c: _noti_broker_home_cb(781) > continue the home key execution
03-26 00:22:09.500+0100 E/W_HOME  (  681): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
03-26 00:22:09.500+0100 W/W_HOME  (  681): move.c: move_move_to_apps(216) > move to apps
03-26 00:22:09.500+0100 W/W_HOME  (  681): rotary.c: rotary_attach(138) > rotary_attach:0x477adae0
03-26 00:22:09.500+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x477adae0, elm_layout, _activated_obj : 0x45b58d58, activated : 1
03-26 00:22:09.500+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:22:09.500+0100 W/W_HOME  (  681): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
03-26 00:22:09.500+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.500+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.500+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:09.510+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
03-26 00:22:09.510+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
03-26 00:22:09.515+0100 W/W_HOME  (  681): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
03-26 00:22:09.515+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
03-26 00:22:09.515+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
03-26 00:22:09.790+0100 W/W_HOME  (  681): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
03-26 00:22:09.790+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.790+0100 W/W_HOME  (  681): rotary.c: rotary_deattach(156) > rotary_deattach:0x477adae0
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x477adae0, elm_layout, func : 0x4004b359
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45b58d58, elm_box, _activated_obj : 0x477adae0, activated : 1
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:22:09.790+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.790+0100 I/wnotib  (  681): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 1, 202.
03-26 00:22:09.790+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
03-26 00:22:09.790+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(578) > apps,show
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:22:09.795+0100 W/W_HOME  (  681): main.c: home_pause(751) > clock/widget paused
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:22:09.795+0100 W/APPS    (  681): apps_main.c: _time_changed_cb(295) >  date : 26->26
03-26 00:22:09.795+0100 W/W_HOME  (  681): rotary.c: rotary_attach(138) > rotary_attach:0x477b5668
03-26 00:22:09.795+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x477b5668, elm_layout, _activated_obj : 0x45b58d58, activated : 1
03-26 00:22:09.795+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:22:09.795+0100 W/W_HOME  (  681): noti_broker.c: _apptray_visibility_cb(788) > apps,show
03-26 00:22:09.795+0100 W/W_HOME  (  681): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
03-26 00:22:09.795+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 I/wnotib  (  681): w-notification-board-panel-basic.c: _wnotib_basic_panel_close_second_depth_view(5438) > wnotib_action_drawer_hidden_get(): 1, page_popup: 0x0
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_is_available(4795) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 I/wnotib  (  681): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1705) > is_app_tray_displayed: 1
03-26 00:22:09.795+0100 E/APPS    (  681): apps_main.c: apps_main_resume(621) >  resumed already
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:22:09.810+0100 W/WATCH_CORE(  702): appcore-watch.c: __widget_pause(1001) > widget_pause
03-26 00:22:10.500+0100 W/AUL_AMD (  491): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
03-26 00:22:10.500+0100 W/AUL_AMD (  491): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
03-26 00:22:11.090+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.090+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 832879
03-26 00:22:11.090+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[4], __pAppsItemList.size[23]
03-26 00:22:11.090+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[5]
03-26 00:22:11.095+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.095+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.095+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.160+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.160+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.160+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 832949
03-26 00:22:11.165+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[5], __pAppsItemList.size[23]
03-26 00:22:11.165+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[6]
03-26 00:22:11.175+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.225+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.225+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.225+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.240+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.240+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833016
03-26 00:22:11.240+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[6], __pAppsItemList.size[23]
03-26 00:22:11.240+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[7]
03-26 00:22:11.240+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.305+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.305+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.305+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.310+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.310+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833097
03-26 00:22:11.310+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[7], __pAppsItemList.size[23]
03-26 00:22:11.310+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[1], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[8]
03-26 00:22:11.310+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.435+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.435+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.440+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833227
03-26 00:22:11.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[7], __pAppsItemList.size[23]
03-26 00:22:11.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[8]
03-26 00:22:11.450+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.470+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:22:11.700+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.195+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833985
03-26 00:22:12.200+0100 W/APPS    (  681): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
03-26 00:22:12.200+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[8], __pAppsItemList.size[23]
03-26 00:22:12.200+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[9]
03-26 00:22:12.260+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834050
03-26 00:22:12.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[9], __pAppsItemList.size[23]
03-26 00:22:12.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[10]
03-26 00:22:12.265+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.310+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834102
03-26 00:22:12.315+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[10], __pAppsItemList.size[23]
03-26 00:22:12.315+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[11]
03-26 00:22:12.320+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.365+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.370+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.370+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.380+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.380+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834157
03-26 00:22:12.380+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[11], __pAppsItemList.size[23]
03-26 00:22:12.380+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[12]
03-26 00:22:12.380+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.420+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.420+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.420+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.425+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.425+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834210
03-26 00:22:12.425+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[12], __pAppsItemList.size[23]
03-26 00:22:12.425+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[13]
03-26 00:22:12.425+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.485+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.485+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.485+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.490+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.490+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834275
03-26 00:22:12.490+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[13], __pAppsItemList.size[23]
03-26 00:22:12.490+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[14]
03-26 00:22:12.490+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.545+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.545+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.545+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.550+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.550+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834337
03-26 00:22:12.550+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[14], __pAppsItemList.size[23]
03-26 00:22:12.550+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
03-26 00:22:12.555+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.785+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:13.050+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834841
03-26 00:22:13.050+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[15], __pAppsItemList.size[23]
03-26 00:22:13.050+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[1], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:22:13.115+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.115+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.115+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.120+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.120+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834905
03-26 00:22:13.120+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[15], __pAppsItemList.size[23]
03-26 00:22:13.120+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:22:13.125+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:13.135+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:22:13.185+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.185+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.185+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834976
03-26 00:22:13.195+0100 E/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
03-26 00:22:13.250+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.255+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.255+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 835042
03-26 00:22:13.260+0100 E/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
03-26 00:22:13.360+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:14.250+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:14.250+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=836042 button=1 downs=1
03-26 00:22:14.250+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [70, 259]
03-26 00:22:14.305+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=836096 button=1 downs=0
03-26 00:22:14.305+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [70, 259]->[86, 251]
03-26 00:22:14.305+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:22:14.305+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:22:14.305+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:14.305+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:22:14.315+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:14.315+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:22:14.315+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:22:14.325+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:14.325+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:22:14.325+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:14.330+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:14.330+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:14.365+0100 I/efl-extension( 2966): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:14.365+0100 I/UXT     ( 2966): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:14.370+0100 I/CAPI_APPFW_APPLICATION( 2966): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:14.375+0100 I/CAPI_APPFW_APPLICATION( 2966): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:14.420+0100 E/TBM     ( 2966): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:14.430+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:14.435+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:14.480+0100 E/EFL     ( 2966): ecore_evas<2966> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:14.620+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1102966626173145894813
