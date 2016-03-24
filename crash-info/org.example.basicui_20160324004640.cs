S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 2655
Date: 2016-03-24 00:46:40+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb452f106

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000010, esi = 0x00000000
ebp = 0xbfacc7c8, esp = 0xbfacc5dc
eax = 0xb452f106, ebx = 0xb7581ff4
ecx = 0x00000032, edx = 0xbfaccd8c
eip = 0xb74553c0

Memory Information
MemTotal:      124 KB
MemFree:        62 KB
Buffers:         5 KB
Cached:     130644 KB
VmPeak:      72384 KB
VmSize:      72384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14660 KB
VmRSS:       14660 KB
VmData:      12380 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31800 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2655 TID = 2655
2655 2659 

Maps Information
b350f000 b3510000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b3511000 b3513000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b3514000 b3538000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b36da000 b36dd000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b36de000 b36ec000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b36ed000 b36fc000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f03000 b3f06000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f07000 b3f0a000 r-xp /usr/lib/libdri2.so.0.0.0
b3f0b000 b3f16000 r-xp /usr/lib/libdrm.so.2.4.0
b3f17000 b3f20000 r-xp /usr/lib/libtbm.so.1.0.0
b3f21000 b3f28000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3f29000 b3f32000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3f33000 b3f3a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3f3b000 b3f41000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f42000 b3f4a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3f4b000 b3f4f000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3f50000 b3f6d000 r-xp /usr/lib/libtts.so
b3f6e000 b40b2000 r-xp /usr/lib/libcairo.so.2.11200.14
b40b6000 b40ce000 r-xp /usr/lib/libefl-assist.so.0.1.0
b40cf000 b40f0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b40f1000 b4101000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4102000 b410d000 r-xp /lib/libnss_files-2.13.so
b434e000 b4375000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4376000 b439b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b439c000 b44bd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b44cd000 b4503000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4505000 b4508000 r-xp /usr/lib/libiniparser.so.0
b450a000 b4514000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4515000 b451e000 r-xp /usr/lib/libappsvc.so.0.1.0
b451f000 b4522000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4523000 b4525000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4526000 b452c000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b452d000 b4530000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b4531000 b4537000 r-xp /usr/lib/libogg.so.0.7.1
b4538000 b4563000 r-xp /usr/lib/libvorbis.so.0.4.3
b4564000 b464f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b465d000 b465f000 r-xp /usr/lib/libXau.so.6.0.0
b4660000 b46c0000 r-xp /usr/lib/libssl.so.1.0.0
b46c5000 b46f6000 r-xp /usr/lib/libidn.so.11.5.44
b46f7000 b4707000 r-xp /usr/lib/libcares.so.2.1.0
b4708000 b4771000 r-xp /usr/lib/libsndfile.so.1.0.25
b4777000 b4781000 r-xp /usr/lib/libsensord-share.so
b4782000 b47a8000 r-xp /lib/libexpat.so.1.5.2
b47aa000 b47d1000 r-xp /usr/lib/libpng12.so.0.50.0
b47d2000 b47f2000 r-xp /usr/lib/libxcb.so.1.1.0
b47f3000 b4862000 r-xp /usr/lib/libcurl.so.4.3.0
b4864000 b486f000 r-xp /usr/lib/libethumb.so.1.7.99
b5dcf000 b5ea7000 r-xp /usr/lib/libstdc++.so.6.0.16
b5eb3000 b5eb6000 r-xp /usr/lib/libctxdata.so.0.0.0
b5eb7000 b5ecd000 r-xp /usr/lib/libremix.so.0.0.0
b5ece000 b5ed0000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5ed1000 b5efd000 r-xp /usr/lib/liblua-5.1.so
b5efe000 b5f08000 r-xp /usr/lib/libembryo.so.1.7.99
b5f09000 b5f4f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f60000 b5f7e000 r-xp /usr/lib/libsensor.so.1.1.0
b5f80000 b6002000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6007000 b603b000 r-xp /usr/lib/libfontconfig.so.1.5.0
b603d000 b6098000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b609a000 b60b0000 r-xp /usr/lib/libfribidi.so.0.3.1
b60b1000 b613d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6141000 b6144000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6145000 b614b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b614c000 b6152000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6154000 b6165000 r-xp /usr/lib/libXext.so.6.4.0
b6166000 b629a000 r-xp /usr/lib/libX11.so.6.3.0
b629e000 b62a3000 r-xp /usr/lib/libXtst.so.6.1.0
b62a4000 b62ac000 r-xp /usr/lib/libXrender.so.1.3.0
b62ad000 b62b6000 r-xp /usr/lib/libXrandr.so.2.2.0
b62b7000 b62b9000 r-xp /usr/lib/libXinerama.so.1.0.0
b62ba000 b62c8000 r-xp /usr/lib/libXi.so.6.1.0
b62c9000 b62cd000 r-xp /usr/lib/libXfixes.so.3.1.0
b62ce000 b62d0000 r-xp /usr/lib/libXgesture.so.7.0.0
b62d1000 b62d3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62d4000 b62d6000 r-xp /usr/lib/libXdamage.so.1.1.0
b62d7000 b62e0000 r-xp /usr/lib/libXcursor.so.1.0.2
b62e1000 b630c000 r-xp /usr/lib/libecore_con.so.1.7.99
b630e000 b6316000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6317000 b6322000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6323000 b6329000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b632a000 b634b000 r-xp /usr/lib/libefreet.so.1.7.99
b634d000 b6359000 r-xp /usr/lib/libedbus.so.1.7.99
b635a000 b64b9000 r-xp /usr/lib/libicuuc.so.51.1
b64c7000 b66d0000 r-xp /usr/lib/libicui18n.so.51.1
b66d9000 b6776000 r-xp /usr/lib/libedje.so.1.7.99
b6778000 b6789000 r-xp /usr/lib/libecore_input.so.1.7.99
b678a000 b6791000 r-xp /usr/lib/libecore_file.so.1.7.99
b6792000 b67b8000 r-xp /usr/lib/libeet.so.1.7.99
b67c1000 b68e9000 r-xp /usr/lib/libevas.so.1.7.99
b6906000 b6939000 r-xp /usr/lib/libecore_evas.so.1.7.99
b693b000 b697f000 r-xp /usr/lib/libecore_x.so.1.7.99
b6981000 b6b7b000 r-xp /usr/lib/libelementary.so.1.7.99
b6b8c000 b6b92000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6b93000 b6b97000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6b9b000 b6b9c000 r-xp /usr/lib/libjournal.so.0.1.0
b6b9d000 b6ce5000 r-xp /usr/lib/libxml2.so.2.7.8
b6cec000 b6cff000 r-xp /lib/libresolv-2.13.so
b6d03000 b6d20000 r-xp /lib/libz.so.1.2.5
b6d21000 b6d24000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d25000 b6d2a000 r-xp /usr/lib/libffi.so.5.0.10
b6d2b000 b6d2c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d2e000 b6d32000 r-xp /lib/libattr.so.1.1.0
b6d33000 b6f45000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f60000 b6f81000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6f82000 b6faa000 r-xp /lib/libm-2.13.so
b6fac000 b7007000 r-xp /usr/lib/libeina.so.1.7.99
b700a000 b7015000 r-xp /usr/lib/libvconf.so.0.2.45
b7016000 b7019000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b701a000 b7068000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7069000 b71ca000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71ce000 b71d5000 r-xp /lib/librt-2.13.so
b71d8000 b71df000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b71e1000 b71fb000 r-xp /lib/libgcc_s-4.6.4.so.1
b71fc000 b7204000 r-xp /lib/libcrypt-2.13.so
b722d000 b7231000 r-xp /lib/libcap.so.2.21
b7232000 b7234000 r-xp /usr/lib/libiri.so
b7236000 b7262000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7263000 b7283000 r-xp /usr/lib/libecore.so.1.7.99
b7292000 b729b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b729c000 b73bf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73c0000 b73d3000 r-xp /usr/lib/libail.so.0.1.0
b73d5000 b73fa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b73fb000 b7405000 r-xp /lib/libunwind.so.8.0.1
b740f000 b7580000 r-xp /lib/libc-2.13.so
b7586000 b75d0000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75d1000 b75d6000 r-xp /usr/lib/libbundle.so.0.1.22
b75d7000 b75da000 r-xp /lib/libdl-2.13.so
b75dd000 b75e2000 r-xp /usr/lib/libsmack.so.1.0.0
b75e3000 b768b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b768e000 b76a8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a9000 b76c0000 r-xp /lib/libpthread-2.13.so
b76c4000 b76c7000 r-xp /usr/lib/libdlog.so.0.0.0
b76c8000 b76d8000 r-xp /usr/lib/libaul.so.0.1.0
b76da000 b76e0000 r-xp /usr/lib/libappcore-common.so.1.1
b76e1000 b76e6000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e8000 b76ed000 r-xp /usr/lib/libsys-assert.so
b76f0000 b770e000 r-xp /lib/ld-2.13.so
b770e000 b770f000 r-xp [vdso]
b7711000 b7718000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:2655)
Call Stack Count: 17
 0: __printf_fp + 0x16a0 (0xb74553c0) [/lib/libc.so.6] + 0x463c0
 1: _IO_vfprintf + 0x48e5 (0xb7453345) [/lib/libc.so.6] + 0x44345
 2: vsprintf + 0xa4 (0xb746ed24) [/lib/libc.so.6] + 0x5fd24
 3: (0xb4529766) [/usr/lib/libcapi-system-sensor.so.0] + 0x3766
 4: (0xb5f708b6) [/usr/lib/libsensor.so.1] + 0x108b6
 5: (0xb72df841) [/usr/lib/libglib-2.0.so.0] + 0x43841
 6: g_main_context_dispatch + 0x133 (0xb72e1dd3) [/usr/lib/libglib-2.0.so.0] + 0x45dd3
 7: (0xb7277d40) [/usr/lib/libecore.so.1] + 0x14d40
 8: (0xb727096f) [/usr/lib/libecore.so.1] + 0xd96f
 9: (0xb7271654) [/usr/lib/libecore.so.1] + 0xe654
10: ecore_main_loop_begin + 0x3f (0xb72719cf) [/usr/lib/libecore.so.1] + 0xe9cf
11: elm_run + 0x17 (0xb6a888a7) [/usr/lib/libelementary.so.1] + 0x1078a7
12: appcore_efl_main + 0x3d1 (0xb76e3e91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
13: ui_app_main + 0x130 (0xb6b955f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
14: main + 0x30d (0xb452e3ad) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x13ad
15: (0xb77145b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77145b1
16: __libc_start_main + 0xf3 (0xb74280f3) [/lib/libc.so.6] + 0x190f3
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
nt_activated_set : 0xb81f6880, elm_scroller, _activated_obj : 0xb81f6880, activated : 1
03-24 00:46:31.803+0900 W/W_HOME  ( 2320): main.c: _resume_cb(589) > clock/widget resumed
03-24 00:46:31.803+0900 D/W_HOME  ( 2320): clock_view.c: clock_view_event_handler(843) > event:10004 received
03-24 00:46:31.803+0900 D/W_HOME  ( 2320): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-24 00:46:31.803+0900 D/W_HOME  ( 2320): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb8270bb8 is resumed
03-24 00:46:31.803+0900 E/APPS    ( 2320): apps_main.c: _window_focus_in_cb(293) >  win[14680071], ev->win[14680067]
03-24 00:46:31.803+0900 W/W_HOME  ( 2320): main.c: _window_visibility_cb(796) > Window [0xE00003] is now visible(0)
03-24 00:46:31.803+0900 D/APP_CORE( 2320): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00003 fully_obscured 0
03-24 00:46:31.803+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
03-24 00:46:31.803+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-24 00:46:31.803+0900 D/APP_CORE( 2320): appcore-efl.c: __do_app(470) > [APP 2320] Event: RESUME State: PAUSED
03-24 00:46:31.803+0900 D/LAUNCH  ( 2320): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
03-24 00:46:31.803+0900 D/APP_CORE( 2320): appcore-efl.c: __do_app(559) > [APP 2320] RESUME
03-24 00:46:31.803+0900 I/CAPI_APPFW_APPLICATION( 2320): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-24 00:46:31.803+0900 D/W_HOME  ( 2320): main.c: _resume_cb(564) > Resumed
03-24 00:46:31.803+0900 E/W_HOME  ( 2320): main.c: _resume_cb(567) > resumed already
03-24 00:46:31.803+0900 D/LAUNCH  ( 2320): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
03-24 00:46:31.803+0900 D/LAUNCH  ( 2320): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
03-24 00:46:31.803+0900 D/APP_CORE( 2320): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-24 00:46:31.803+0900 E/APP_CORE( 2320): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-24 00:46:31.803+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
03-24 00:46:31.803+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
03-24 00:46:31.803+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
03-24 00:46:31.813+0900 D/DATA_PROVIDER_MASTER( 2352): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2320 is resumed
03-24 00:46:31.813+0900 D/DATA_PROVIDER_MASTER( 2352): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-24 00:46:32.983+0900 D/PKGMGR_INFO( 2608): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:32.983+0900 D/PKGMGR_INFO( 2608): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:32.993+0900 D/PKGMGR_INFO( 2608): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:32.993+0900 D/PKGMGR_INFO( 2608): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:32.993+0900 D/PKGMGR_INFO( 2608): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:32.993+0900 D/PKGMGR_INFO( 2608): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:33.043+0900 D/AUL     ( 2629): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
03-24 00:46:33.043+0900 D/AUL     ( 2629): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-24 00:46:33.043+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-24 00:46:33.053+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
03-24 00:46:33.053+0900 D/AUL     ( 2226): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2175, pid = 2629
03-24 00:46:33.053+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-24 00:46:33.053+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1785) > process_pool: false
03-24 00:46:33.053+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-24 00:46:33.053+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.tizen.crash-popup
03-24 00:46:33.053+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-24 00:46:33.053+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-24 00:46:33.053+0900 D/AUL_PAD ( 2256): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
03-24 00:46:33.053+0900 D/AUL_PAD ( 2256): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-24 00:46:33.053+0900 D/AUL_PAD ( 2256): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2630 /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-24 00:46:33.053+0900 D/AUL_PAD ( 2256): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 00:46:33.053+0900 D/AUL_PAD ( 2630): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-24 00:46:33.053+0900 D/AUL_PAD ( 2630): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-24 00:46:33.053+0900 D/AUL_PAD ( 2630): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
03-24 00:46:33.063+0900 D/AUL_PAD ( 2630): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
03-24 00:46:33.063+0900 D/LAUNCH  ( 2630): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
03-24 00:46:33.083+0900 D/LAUNCH  ( 2630): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
03-24 00:46:33.093+0900 D/APP_CORE( 2630): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-24 00:46:33.093+0900 D/AUL     ( 2630): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 2630 is org.tizen.crash-popup
03-24 00:46:33.093+0900 D/APP_CORE( 2630): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
03-24 00:46:33.093+0900 D/APP_CORE( 2630): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-24 00:46:33.093+0900 D/AUL     ( 2630): app_sock.c: __create_server_sock(136) > pg path - already exists
03-24 00:46:33.093+0900 D/LAUNCH  ( 2630): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
03-24 00:46:33.103+0900 D/EFL-ASSIST( 2630): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
03-24 00:46:33.103+0900 D/EFL-ASSIST( 2630): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
03-24 00:46:33.103+0900 I/EFL-ASSIST( 2630): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b80d29b8]
03-24 00:46:33.103+0900 D/EFL-ASSIST( 2630): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
03-24 00:46:33.103+0900 I/EFL-ASSIST( 2630): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
03-24 00:46:33.103+0900 I/EFL-ASSIST( 2630): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b80fbe18) from (/usr/share/themes/ChangeableColorTable1.xml) is created
03-24 00:46:33.113+0900 I/EFL-ASSIST( 2630): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b80fbe18) is freed
03-24 00:46:33.113+0900 I/EFL-ASSIST( 2630): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
03-24 00:46:33.113+0900 I/EFL-ASSIST( 2630): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
03-24 00:46:33.113+0900 D/APP_CORE( 2630): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-24 00:46:33.113+0900 D/LAUNCH  ( 2630): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
03-24 00:46:33.113+0900 D/APP_CORE( 2630): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-24 00:46:33.113+0900 D/APP_CORE( 2630): appcore.c: __aul_handler(423) > [APP 2630]     AUL event: AUL_START
03-24 00:46:33.113+0900 D/APP_CORE( 2630): appcore-efl.c: __do_app(470) > [APP 2630] Event: RESET State: CREATED
03-24 00:46:33.113+0900 D/APP_CORE( 2630): appcore-efl.c: __do_app(496) > [APP 2630] RESET
03-24 00:46:33.113+0900 D/LAUNCH  ( 2630): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
03-24 00:46:33.113+0900 D/CRASH_POPUP( 2630): crash.c: app_reset(226) > bundle_get_val - process_name:basicui
03-24 00:46:33.113+0900 D/CRASH_POPUP( 2630): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.example.basicui/bin/basicui
03-24 00:46:33.123+0900 D/PKGMGR_INFO( 2630): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:33.123+0900 D/PKGMGR_INFO( 2630): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:33.123+0900 D/PKGMGR_INFO( 2630): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:33.123+0900 D/PKGMGR_INFO( 2630): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 00:46:33.123+0900 I/CRASH_POPUP( 2630): crash.c: load_crash_process_popup(117) > Popup content: basicui has closed unexpectedly.
03-24 00:46:33.133+0900 D/W_HOME  ( 2320): main.c: _window_focus_out_cb(869) > focus out
03-24 00:46:33.133+0900 D/W_HOME  ( 2320): main.c: _pause_cb(600) > Paused
03-24 00:46:33.133+0900 D/W_HOME  ( 2320): page.c: page_focus(701) > focus set to 0xb83195c8
03-24 00:46:33.133+0900 W/W_HOME  ( 2320): main.c: _pause_cb(613) > clock/widget paused
03-24 00:46:33.133+0900 D/W_HOME  ( 2320): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-24 00:46:33.133+0900 D/W_HOME  ( 2320): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb8270bb8 is paused
03-24 00:46:33.133+0900 E/APPS    ( 2320): apps_main.c: _window_focus_out_cb(313) >  win[14680071], ev->win[14680067]
03-24 00:46:33.133+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
03-24 00:46:33.143+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
03-24 00:46:33.143+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
03-24 00:46:33.153+0900 D/DATA_PROVIDER_MASTER( 2352): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2320 is paused
03-24 00:46:33.153+0900 D/DATA_PROVIDER_MASTER( 2352): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-24 00:46:33.153+0900 E/EFL     ( 2630): eina_module<2630> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-24 00:46:33.153+0900 D/AUL_PAD ( 2256): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-24 00:46:33.153+0900 D/AUL_PAD ( 2256): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-24 00:46:33.153+0900 D/AUL_PAD ( 2256): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-24 00:46:33.153+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 00:46:33.153+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 00:46:33.153+0900 D/RESOURCED( 2416): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-24 00:46:33.153+0900 D/RESOURCED( 2416): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2226
03-24 00:46:33.153+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 2630, type 4 
03-24 00:46:33.153+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 2630
03-24 00:46:33.153+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
03-24 00:46:33.153+0900 E/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 379
03-24 00:46:33.153+0900 D/RESOURCED( 2416): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-24 00:46:33.153+0900 D/AUL     ( 2629): launch.c: app_request_to_launchpad(295) > launch request result : 2630
03-24 00:46:33.193+0900 D/LAUNCH  ( 2630): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
03-24 00:46:33.193+0900 I/APP_CORE( 2630): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-24 00:46:33.193+0900 I/APP_CORE( 2630): appcore-efl.c: __do_app(509) > [APP 2630] Initial Launching, call the resume_cb
03-24 00:46:33.193+0900 D/APP_CORE( 2630): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-24 00:46:33.193+0900 D/APP_CORE( 2630): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00006
03-24 00:46:33.193+0900 D/APP_CORE( 2630): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00006
03-24 00:46:33.263+0900 D/AUL_AMD ( 2226): amd_launch.c: __e17_status_handler(1911) > pid(2630) status(3)
03-24 00:46:33.263+0900 D/RESOURCED( 2416): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2630, type = 0
03-24 00:46:33.263+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2630
03-24 00:46:33.263+0900 I/RESOURCED( 2416): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 2630, oom : 200
03-24 00:46:33.263+0900 E/RESOURCED( 2416): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-24 00:46:33.263+0900 E/RESOURCED( 2416): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (2630) didn't have any process list
03-24 00:46:33.263+0900 D/RESOURCED( 2416): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2630, appname = (null)
03-24 00:46:33.263+0900 D/RESOURCED( 2416): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2630
03-24 00:46:33.393+0900 D/APP_CORE( 2630): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00006 fully_obscured 0
03-24 00:46:33.393+0900 D/APP_CORE( 2630): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-24 00:46:33.393+0900 D/APP_CORE( 2630): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-24 00:46:33.393+0900 D/APP_CORE( 2630): appcore-efl.c: __do_app(470) > [APP 2630] Event: RESUME State: RUNNING
03-24 00:46:33.393+0900 D/LAUNCH  ( 2630): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
03-24 00:46:33.393+0900 D/LAUNCH  ( 2630): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
03-24 00:46:33.393+0900 D/LAUNCH  ( 2630): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
03-24 00:46:33.393+0900 D/APP_CORE( 2630): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-24 00:46:33.393+0900 E/APP_CORE( 2630): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-24 00:46:33.593+0900 D/APP_CORE( 2630): appcore.c: __prt_ltime(183) > [APP 2630] first idle after reset: 549 msec
03-24 00:46:34.153+0900 D/AUL_AMD ( 2226): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-24 00:46:34.153+0900 D/RUA     ( 2226): rua.c: rua_add_history(179) > rua_add_history start
03-24 00:46:34.163+0900 D/RUA     ( 2226): rua.c: rua_add_history(247) > rua_add_history ok
03-24 00:46:36.453+0900 I/GESTURE ( 2070): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 00:46:36.503+0900 D/EFL     ( 2630): ecore_x<2630> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=252467 button=1
03-24 00:46:36.573+0900 D/EFL     ( 2630): ecore_x<2630> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=252585 button=1
03-24 00:46:36.573+0900 E/EFL     ( 2630): eina_module<2630> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-24 00:46:36.963+0900 D/AUL     ( 2630): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-24 00:46:36.963+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 22
03-24 00:46:36.963+0900 D/APP_CORE( 2630): appcore-efl.c: __after_loop(1062) > [APP 2630] PAUSE before termination
03-24 00:46:36.963+0900 D/W_HOME  ( 2320): main.c: _window_focus_in_cb(848) > focus in
03-24 00:46:36.963+0900 D/W_HOME  ( 2320): main.c: _resume_cb(564) > Resumed
03-24 00:46:36.963+0900 D/APPS    ( 2320): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
03-24 00:46:36.963+0900 D/W_HOME  ( 2320): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
03-24 00:46:36.963+0900 E/efl-extension( 2320): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb81f6880, elm_scroller, _activated_obj : 0xb81f6880, activated : 1
03-24 00:46:36.963+0900 W/W_HOME  ( 2320): main.c: _resume_cb(589) > clock/widget resumed
03-24 00:46:36.963+0900 D/W_HOME  ( 2320): clock_view.c: clock_view_event_handler(843) > event:10004 received
03-24 00:46:36.963+0900 D/W_HOME  ( 2320): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-24 00:46:36.963+0900 D/W_HOME  ( 2320): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb8270bb8 is resumed
03-24 00:46:36.963+0900 E/APPS    ( 2320): apps_main.c: _window_focus_in_cb(293) >  win[14680071], ev->win[14680067]
03-24 00:46:36.963+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
03-24 00:46:36.963+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
03-24 00:46:36.963+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
03-24 00:46:36.973+0900 D/DATA_PROVIDER_MASTER( 2352): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2320 is resumed
03-24 00:46:36.973+0900 D/DATA_PROVIDER_MASTER( 2352): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-24 00:46:37.003+0900 I/AUL_PAD ( 2256): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2630 pgid = 2630
03-24 00:46:37.003+0900 I/AUL_PAD ( 2256): sigchild.h: __sigchild_action(123) > dead_pid(2630)
03-24 00:46:37.003+0900 D/AUL_PAD ( 2256): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-24 00:46:37.003+0900 I/AUL_PAD ( 2256): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-24 00:46:37.003+0900 I/AUL_PAD ( 2256): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-24 00:46:37.003+0900 I/AUL_AMD ( 2226): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2630
03-24 00:46:37.003+0900 D/AUL_AMD ( 2226): amd_key.c: _unregister_key_event(161) > ===key stack===
03-24 00:46:37.003+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 00:46:37.003+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 00:46:37.003+0900 D/W_HOME  ( 2320): main.c: _dead_cb(542) > PID(2630) is dead
03-24 00:46:37.003+0900 E/W_HOME  ( 2320): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-24 00:46:37.003+0900 D/STARTER ( 2313): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2630)
03-24 00:46:38.083+0900 I/GESTURE ( 2070): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 00:46:38.133+0900 D/EFL     ( 2320): ecore_x<2320> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=254097 button=1
03-24 00:46:38.133+0900 D/W_HOME  ( 2320): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-24 00:46:38.133+0900 D/W_HOME  ( 2320): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
03-24 00:46:38.133+0900 D/W_HOME  ( 2320): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:341
03-24 00:46:38.133+0900 D/W_HOME  ( 2320): layout.c: _down_cb(250) > Mouse is down on the layout
03-24 00:46:38.133+0900 W/W_HOME  ( 2320): layout.c: _down_cb(280) > we don't add a longpress timer, it's too close to home key
03-24 00:46:38.133+0900 D/W_HOME  ( 2320): page.c: _down_cb(84) > Down (0xb8237180)(183, 341)
03-24 00:46:38.213+0900 D/W_HOME  ( 2320): layout.c: _bezel_up_cb(348) > Bezel up cb
03-24 00:46:38.223+0900 D/APPS    ( 2320): apps_main.c: apps_main_launch(588) >  APPS LAUNCH
03-24 00:46:38.223+0900 D/APPS    ( 2320): apps_main.c: apps_main_launch(618) >  Show the Apps
03-24 00:46:38.223+0900 D/APPS    ( 2320): apps_main.c: apps_main_launch(625) >  There is a window already
03-24 00:46:38.223+0900 D/APPS    ( 2320): layout.c: apps_layout_show(476) >  (0xb8272878) Show the tray
03-24 00:46:38.263+0900 D/APP_CORE( 2320): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:e00007
03-24 00:46:38.263+0900 D/APP_CORE( 2320): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:e00007
03-24 00:46:38.263+0900 D/W_HOME  ( 2320): main.c: _window_focus_out_cb(869) > focus out
03-24 00:46:38.263+0900 D/W_HOME  ( 2320): main.c: _pause_cb(600) > Paused
03-24 00:46:38.273+0900 D/W_HOME  ( 2320): page.c: page_focus(701) > focus set to 0xb83195c8
03-24 00:46:38.273+0900 W/W_HOME  ( 2320): main.c: _pause_cb(613) > clock/widget paused
03-24 00:46:38.273+0900 D/W_HOME  ( 2320): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-24 00:46:38.273+0900 D/W_HOME  ( 2320): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb8270bb8 is paused
03-24 00:46:38.273+0900 E/APPS    ( 2320): apps_main.c: _window_focus_out_cb(313) >  win[14680071], ev->win[14680067]
03-24 00:46:38.273+0900 E/W_HOME  ( 2320): main.c: _window_focus_in_cb(851) > win[14680067], ev->win[14680071]
03-24 00:46:38.273+0900 D/APPS    ( 2320): apps_main.c: _window_focus_in_cb(288) >  focus in
03-24 00:46:38.273+0900 E/W_HOME  ( 2320): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-24 00:46:38.273+0900 D/APPS    ( 2320): apps_main.c: apps_main_resume(693) >  Resume starts
03-24 00:46:38.273+0900 D/APPS    ( 2320): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-24 00:46:38.283+0900 E/efl-extension( 2320): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb83331a8, elm_scroller, _activated_obj : 0xb81f6880, activated : 1
03-24 00:46:38.283+0900 E/efl-extension( 2320): efl_extension_rotary.c: eext_rotary_object_event_activated_set(309) > Activation delete!!!!
03-24 00:46:38.293+0900 D/DATA_PROVIDER_MASTER( 2352): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2320 is paused
03-24 00:46:38.293+0900 D/DATA_PROVIDER_MASTER( 2352): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-24 00:46:38.293+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
03-24 00:46:38.293+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
03-24 00:46:38.293+0900 D/IDLE-CLOCK-DIGITAL( 2327): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
03-24 00:46:38.303+0900 D/APP_CORE( 2320): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00007 fully_obscured 0
03-24 00:46:38.303+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 1
03-24 00:46:38.303+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(909) >  No change state 
03-24 00:46:38.303+0900 W/W_HOME  ( 2320): main.c: _window_visibility_cb(796) > Window [0xE00003] is now visible(1)
03-24 00:46:38.303+0900 D/APP_CORE( 2320): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00003 fully_obscured 1
03-24 00:46:38.303+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 1
03-24 00:46:38.303+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(909) >  No change state 
03-24 00:46:38.403+0900 D/EFL     ( 2320): ecore_x<2320> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=254411 button=1
03-24 00:46:38.403+0900 D/W_HOME  ( 2320): layout.c: _up_cb(324) > Mouse is up on the layout
03-24 00:46:38.403+0900 D/W_HOME  ( 2320): page.c: _up_cb(115) > Up (0xb8237180)(173, 143)
03-24 00:46:38.403+0900 D/W_HOME  ( 2320): page.c: _up_cb(129) > Event ON_HOLD flag set on a page(0xb8237180)
03-24 00:46:38.913+0900 I/GESTURE ( 2070): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 00:46:38.963+0900 D/AUL_AMD ( 2226): amd_status.c: __app_terminate_timer_cb(113) > pid(2630)
03-24 00:46:38.963+0900 D/AUL_AMD ( 2226): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-24 00:46:38.963+0900 D/EFL     ( 2320): ecore_x<2320> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=254922 button=1
03-24 00:46:38.963+0900 D/APPS    ( 2320): scroller.c: _mouse_down_cb(100) >  Mouse is down [229,203]
03-24 00:46:38.963+0900 D/APPS    ( 2320): item.c: _down_cb(381) >  Down (Settings,0xb8380470) (229, 203), item pos(41,1,280,390)
03-24 00:46:38.963+0900 E/APPS    ( 2320): item.c: _down_cb(425) >  longpress edit mode disable
03-24 00:46:38.963+0900 W/APPS    ( 2320): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 00:46:39.013+0900 D/APPS    ( 2320): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-24 00:46:39.023+0900 W/APPS    ( 2320): item.c: _anim_item_released_cb(1075) >  item is released
03-24 00:46:39.093+0900 D/EFL     ( 2320): ecore_x<2320> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=255074 button=1
03-24 00:46:39.093+0900 D/APPS    ( 2320): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-24 00:46:39.093+0900 D/APPS    ( 2320): scroller.c: _anim_start_cb(122) >  start the scroller animation
03-24 00:46:39.093+0900 D/APPS    ( 2320): scroller.c: _mouse_up_cb(111) >  Mouse is up [40,214]
03-24 00:46:39.093+0900 D/APPS    ( 2320): item.c: _up_cb(573) >  Up (Settings,0xb8380470) (40, 214), item pos(-200,1,280,390)
03-24 00:46:39.093+0900 D/APPS    ( 2320): item.c: _up_cb(634) >  cur_x,cur_y: [-60, 196]
03-24 00:46:39.093+0900 W/APPS    ( 2320): item.c: _anim_item_released_cb(1075) >  item is released
03-24 00:46:39.093+0900 W/APPS    ( 2320): item.c: _anim_item_released_cb(1075) >  item is released
03-24 00:46:39.093+0900 D/APPS    ( 2320): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 00:46:39.303+0900 D/APPS    ( 2320): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
03-24 00:46:39.693+0900 I/GESTURE ( 2070): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 00:46:39.743+0900 D/EFL     ( 2320): ecore_x<2320> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=255700 button=1
03-24 00:46:39.743+0900 D/APPS    ( 2320): scroller.c: _mouse_down_cb(100) >  Mouse is down [138,203]
03-24 00:46:39.743+0900 D/APPS    ( 2320): item.c: _down_cb(381) >  Down (basicui,0xb8319cf8) (138, 203), item pos(41,1,280,390)
03-24 00:46:39.743+0900 E/APPS    ( 2320): item.c: _down_cb(425) >  longpress edit mode disable
03-24 00:46:39.763+0900 W/APPS    ( 2320): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 00:46:39.803+0900 D/EFL     ( 2320): ecore_x<2320> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=255819 button=1
03-24 00:46:39.803+0900 D/APPS    ( 2320): scroller.c: _mouse_up_cb(111) >  Mouse is up [138,203]
03-24 00:46:39.803+0900 D/APPS    ( 2320): item.c: _up_cb(573) >  Up (basicui,0xb8319cf8) (138, 203), item pos(41,1,280,390)
03-24 00:46:39.813+0900 E/APPS    ( 2320): item.c: _clicked_cb(65) >  Clicked
03-24 00:46:39.813+0900 E/APPS    ( 2320): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-24 00:46:39.813+0900 D/APPS    ( 2320): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-24 00:46:39.813+0900 D/APP_SVC ( 2320): appsvc.c: __set_bundle(161) > __set_bundle
03-24 00:46:39.813+0900 D/APP_SVC ( 2320): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-24 00:46:39.813+0900 D/APP_SVC ( 2320): appsvc.c: __set_bundle(161) > __set_bundle
03-24 00:46:39.813+0900 D/W_HOME  ( 2320): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-24 00:46:39.813+0900 D/W_HOME  ( 2320): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-24 00:46:39.813+0900 D/APP_SVC ( 2320): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-24 00:46:39.813+0900 D/AUL     ( 2320): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-24 00:46:39.813+0900 D/AUL     ( 2320): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-24 00:46:39.813+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-24 00:46:39.813+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-24 00:46:39.813+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-24 00:46:39.823+0900 E/AUL_AMD ( 2226): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-24 00:46:39.823+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-24 00:46:39.823+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1785) > process_pool: false
03-24 00:46:39.823+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-24 00:46:39.823+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-24 00:46:39.823+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-24 00:46:39.823+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-24 00:46:39.823+0900 D/AUL_PAD ( 2256): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-24 00:46:39.823+0900 D/AUL_PAD ( 2256): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-24 00:46:39.823+0900 D/AUL_PAD ( 2256): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2655 /opt/usr/apps/org.example.basicui/bin/basicui
03-24 00:46:39.823+0900 D/AUL_PAD ( 2256): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-24 00:46:39.823+0900 D/AUL_PAD ( 2655): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-24 00:46:39.823+0900 D/LAUNCH  ( 2655): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-24 00:46:39.833+0900 I/efl-extension( 2655): efl_extension.c: eext_mod_init(39) > Init
03-24 00:46:39.843+0900 I/CAPI_APPFW_APPLICATION( 2655): app_main.c: ui_app_main(701) > app_efl_main
03-24 00:46:39.843+0900 D/LAUNCH  ( 2655): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-24 00:46:39.853+0900 D/APP_CORE( 2655): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-24 00:46:39.853+0900 D/AUL     ( 2655): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 2655 is org.example.basicui
03-24 00:46:39.853+0900 D/APP_CORE( 2655): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-24 00:46:39.853+0900 D/APP_CORE( 2655): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-24 00:46:39.853+0900 D/AUL     ( 2655): app_sock.c: __create_server_sock(136) > pg path - already exists
03-24 00:46:39.853+0900 D/LAUNCH  ( 2655): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-24 00:46:39.853+0900 I/CAPI_APPFW_APPLICATION( 2655): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-24 00:46:39.873+0900 E/EFL     ( 2655): eina_module<2655> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-24 00:46:39.873+0900 E/EFL     ( 2655): ecore_evas<2655> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-24 00:46:39.873+0900 E/EFL     ( 2655): elementary<2655> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-24 00:46:39.883+0900 E/EFL     ( 2655): eina_module<2655> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-24 00:46:39.893+0900 I/basicui ( 2655): started
03-24 00:46:39.893+0900 I/basicui ( 2655): listener
03-24 00:46:39.893+0900 D/LAUNCH  ( 2655): appcore-efl.c: __before_loop(1047) > [basicui:Application:create:done]
03-24 00:46:39.893+0900 D/APP_CORE( 2655): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-24 00:46:39.893+0900 D/APP_CORE( 2655): appcore.c: __aul_handler(423) > [APP 2655]     AUL event: AUL_START
03-24 00:46:39.893+0900 D/APP_CORE( 2655): appcore-efl.c: __do_app(470) > [APP 2655] Event: RESET State: CREATED
03-24 00:46:39.893+0900 D/APP_CORE( 2655): appcore-efl.c: __do_app(496) > [APP 2655] RESET
03-24 00:46:39.893+0900 D/LAUNCH  ( 2655): appcore-efl.c: __do_app(498) > [basicui:Application:reset:start]
03-24 00:46:39.893+0900 I/CAPI_APPFW_APPLICATION( 2655): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-24 00:46:39.893+0900 D/LAUNCH  ( 2655): appcore-efl.c: __do_app(501) > [basicui:Application:reset:done]
03-24 00:46:39.893+0900 I/APP_CORE( 2655): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-24 00:46:39.903+0900 I/APP_CORE( 2655): appcore-efl.c: __do_app(509) > [APP 2655] Initial Launching, call the resume_cb
03-24 00:46:39.903+0900 I/CAPI_APPFW_APPLICATION( 2655): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-24 00:46:39.903+0900 D/APP_CORE( 2655): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.w-home
03-24 00:46:39.903+0900 D/APP_CORE( 2655): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
03-24 00:46:39.903+0900 D/APP_CORE( 2655): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
03-24 00:46:39.923+0900 D/AUL_PAD ( 2256): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-24 00:46:39.923+0900 D/AUL_PAD ( 2256): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-24 00:46:39.923+0900 D/AUL_PAD ( 2256): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-24 00:46:39.923+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 00:46:39.923+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 00:46:39.923+0900 D/RESOURCED( 2416): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-24 00:46:39.923+0900 D/RESOURCED( 2416): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2226
03-24 00:46:39.923+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 2655, type 4 
03-24 00:46:39.923+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 2655
03-24 00:46:39.923+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-24 00:46:39.923+0900 E/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 378
03-24 00:46:39.923+0900 D/RESOURCED( 2416): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-24 00:46:39.923+0900 D/AUL     ( 2320): launch.c: app_request_to_launchpad(295) > launch request result : 2655
03-24 00:46:39.923+0900 D/W_HOME  ( 2320): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.example.basicui:basicui) ret : [0]
03-24 00:46:39.923+0900 D/LAUNCH  ( 2320): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.example.basicui:Menuscreen:launch:done]
03-24 00:46:39.923+0900 E/W_HOME  ( 2320): main.c: _window_focus_out_cb(885) > win[14680067], ev->win[14680071]
03-24 00:46:39.923+0900 D/APPS    ( 2320): apps_main.c: _window_focus_out_cb(308) >  focus out
03-24 00:46:39.923+0900 E/W_HOME  ( 2320): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-24 00:46:39.923+0900 D/APPS    ( 2320): apps_main.c: apps_main_pause(656) >  Pause starts
03-24 00:46:39.923+0900 D/APPS    ( 2320): apps_main.c: apps_main_pause(676) >  Pause done
03-24 00:46:39.923+0900 W/APPS    ( 2320): item.c: _anim_item_released_cb(1075) >  item is released
03-24 00:46:39.923+0900 D/APPS    ( 2320): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 00:46:39.963+0900 D/APP_CORE( 2655): appcore.c: __prt_ltime(183) > [APP 2655] first idle after reset: 148 msec
03-24 00:46:39.973+0900 D/APP_CORE( 2320): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00007 fully_obscured 1
03-24 00:46:39.973+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-24 00:46:39.973+0900 D/APP_CORE( 2320): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-24 00:46:39.973+0900 D/APP_CORE( 2320): appcore-efl.c: __do_app(470) > [APP 2320] Event: PAUSE State: RUNNING
03-24 00:46:39.973+0900 D/APP_CORE( 2320): appcore-efl.c: __do_app(538) > [APP 2320] PAUSE
03-24 00:46:39.973+0900 I/CAPI_APPFW_APPLICATION( 2320): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-24 00:46:39.973+0900 D/W_HOME  ( 2320): main.c: _pause_cb(600) > Paused
03-24 00:46:39.973+0900 E/W_HOME  ( 2320): main.c: _pause_cb(603) > paused already
03-24 00:46:39.973+0900 D/APP_CORE( 2320): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-24 00:46:39.973+0900 E/APP_CORE( 2320): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-24 00:46:39.973+0900 D/RESOURCED( 2416): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2320, type = 2
03-24 00:46:39.973+0900 D/AUL_AMD ( 2226): amd_launch.c: __e17_status_handler(1911) > pid(2655) status(3)
03-24 00:46:39.973+0900 D/RESOURCED( 2416): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2655, type = 0
03-24 00:46:39.973+0900 D/RESOURCED( 2416): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2655
03-24 00:46:39.973+0900 I/RESOURCED( 2416): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 2655, oom : 200
03-24 00:46:39.973+0900 E/RESOURCED( 2416): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-24 00:46:39.973+0900 D/APP_CORE( 2655): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
03-24 00:46:39.973+0900 D/APP_CORE( 2655): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-24 00:46:39.973+0900 D/APP_CORE( 2655): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-24 00:46:39.973+0900 D/APP_CORE( 2655): appcore-efl.c: __do_app(470) > [APP 2655] Event: RESUME State: RUNNING
03-24 00:46:39.983+0900 D/LAUNCH  ( 2655): appcore-efl.c: __do_app(557) > [basicui:Application:resume:start]
03-24 00:46:39.983+0900 D/LAUNCH  ( 2655): appcore-efl.c: __do_app(567) > [basicui:Application:resume:done]
03-24 00:46:39.983+0900 D/LAUNCH  ( 2655): appcore-efl.c: __do_app(569) > [basicui:Application:Launching:done]
03-24 00:46:39.983+0900 D/APP_CORE( 2655): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-24 00:46:39.983+0900 E/APP_CORE( 2655): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-24 00:46:40.863+0900 W/CRASH_MANAGER( 2608): worker.c: worker_job(1189) > 1102655626173145874800
