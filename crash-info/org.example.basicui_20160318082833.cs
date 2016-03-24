S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:39

Crash Information
Process Name: basicui
PID: 3596
Date: 2016-03-18 08:28:33+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb4581927

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xbfe458f8
ebp = 0xbfe45948, esp = 0xbfe458a8
eax = 0x30302e30, ebx = 0xb4582d70
ecx = 0xbfe458f8, edx = 0xf473c02f
eip = 0xb74d57ad

Memory Information
MemTotal:      124 KB
MemFree:        23 KB
Buffers:        12 KB
Cached:     138892 KB
VmPeak:      70196 KB
VmSize:      70196 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12584 KB
VmRSS:       12584 KB
VmData:      11428 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31784 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3596 TID = 3596
3596 3600 

Maps Information
b35df000 b3603000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b376c000 b376f000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3770000 b377e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b377f000 b378e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f94000 b3f97000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f98000 b3f9b000 r-xp /usr/lib/libdri2.so.0.0.0
b3f9c000 b3fa7000 r-xp /usr/lib/libdrm.so.2.4.0
b3fa8000 b3fb1000 r-xp /usr/lib/libtbm.so.1.0.0
b3fb2000 b3fb9000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3fba000 b3fc3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3fc4000 b3fcb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3fcc000 b3fd2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fd3000 b3fdb000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3fdc000 b3fe0000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3fe1000 b3ffe000 r-xp /usr/lib/libtts.so
b3fff000 b4143000 r-xp /usr/lib/libcairo.so.2.11200.14
b4147000 b415f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4160000 b4181000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4182000 b4192000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4193000 b419e000 r-xp /lib/libnss_files-2.13.so
b43a0000 b43c7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b43c8000 b43ed000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b43ee000 b450f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b451f000 b4555000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4557000 b455a000 r-xp /usr/lib/libiniparser.so.0
b455c000 b4566000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4567000 b4570000 r-xp /usr/lib/libappsvc.so.0.1.0
b4571000 b4574000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4576000 b4578000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4579000 b457f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b4580000 b4582000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b4583000 b4589000 r-xp /usr/lib/libogg.so.0.7.1
b458a000 b45b5000 r-xp /usr/lib/libvorbis.so.0.4.3
b45b6000 b46a1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46af000 b46b1000 r-xp /usr/lib/libXau.so.6.0.0
b46b2000 b4712000 r-xp /usr/lib/libssl.so.1.0.0
b4717000 b4748000 r-xp /usr/lib/libidn.so.11.5.44
b4749000 b4759000 r-xp /usr/lib/libcares.so.2.1.0
b475a000 b47c3000 r-xp /usr/lib/libsndfile.so.1.0.25
b47c9000 b47d3000 r-xp /usr/lib/libsensord-share.so
b47d4000 b47fa000 r-xp /lib/libexpat.so.1.5.2
b47fc000 b4823000 r-xp /usr/lib/libpng12.so.0.50.0
b4824000 b4844000 r-xp /usr/lib/libxcb.so.1.1.0
b4845000 b48b4000 r-xp /usr/lib/libcurl.so.4.3.0
b48b6000 b48c1000 r-xp /usr/lib/libethumb.so.1.7.99
b5e21000 b5ef9000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f05000 b5f08000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f09000 b5f1f000 r-xp /usr/lib/libremix.so.0.0.0
b5f20000 b5f22000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f23000 b5f4f000 r-xp /usr/lib/liblua-5.1.so
b5f50000 b5f5a000 r-xp /usr/lib/libembryo.so.1.7.99
b5f5b000 b5fa1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5fb2000 b5fd0000 r-xp /usr/lib/libsensor.so.1.1.0
b5fd2000 b6054000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6059000 b608d000 r-xp /usr/lib/libfontconfig.so.1.5.0
b608f000 b60ea000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b60ec000 b6102000 r-xp /usr/lib/libfribidi.so.0.3.1
b6103000 b618f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6193000 b6196000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6197000 b619d000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b619e000 b61a4000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61a6000 b61b7000 r-xp /usr/lib/libXext.so.6.4.0
b61b8000 b62ec000 r-xp /usr/lib/libX11.so.6.3.0
b62f0000 b62f5000 r-xp /usr/lib/libXtst.so.6.1.0
b62f6000 b62fe000 r-xp /usr/lib/libXrender.so.1.3.0
b62ff000 b6308000 r-xp /usr/lib/libXrandr.so.2.2.0
b6309000 b630b000 r-xp /usr/lib/libXinerama.so.1.0.0
b630c000 b631a000 r-xp /usr/lib/libXi.so.6.1.0
b631b000 b631f000 r-xp /usr/lib/libXfixes.so.3.1.0
b6320000 b6322000 r-xp /usr/lib/libXgesture.so.7.0.0
b6323000 b6325000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6326000 b6328000 r-xp /usr/lib/libXdamage.so.1.1.0
b6329000 b6332000 r-xp /usr/lib/libXcursor.so.1.0.2
b6333000 b635e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6360000 b6368000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6369000 b6374000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6375000 b637b000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b637c000 b639d000 r-xp /usr/lib/libefreet.so.1.7.99
b639f000 b63ab000 r-xp /usr/lib/libedbus.so.1.7.99
b63ac000 b650b000 r-xp /usr/lib/libicuuc.so.51.1
b6519000 b6722000 r-xp /usr/lib/libicui18n.so.51.1
b672b000 b67c8000 r-xp /usr/lib/libedje.so.1.7.99
b67ca000 b67db000 r-xp /usr/lib/libecore_input.so.1.7.99
b67dc000 b67e3000 r-xp /usr/lib/libecore_file.so.1.7.99
b67e4000 b680a000 r-xp /usr/lib/libeet.so.1.7.99
b6813000 b693b000 r-xp /usr/lib/libevas.so.1.7.99
b6958000 b698b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b698d000 b69d1000 r-xp /usr/lib/libecore_x.so.1.7.99
b69d3000 b6bcd000 r-xp /usr/lib/libelementary.so.1.7.99
b6bde000 b6be4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6be5000 b6be9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bed000 b6bee000 r-xp /usr/lib/libjournal.so.0.1.0
b6bef000 b6d37000 r-xp /usr/lib/libxml2.so.2.7.8
b6d3e000 b6d51000 r-xp /lib/libresolv-2.13.so
b6d55000 b6d72000 r-xp /lib/libz.so.1.2.5
b6d73000 b6d76000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d77000 b6d7c000 r-xp /usr/lib/libffi.so.5.0.10
b6d7d000 b6d7e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d80000 b6d84000 r-xp /lib/libattr.so.1.1.0
b6d85000 b6f97000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fb2000 b6fd3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fd4000 b6ffc000 r-xp /lib/libm-2.13.so
b6ffe000 b7059000 r-xp /usr/lib/libeina.so.1.7.99
b705c000 b7067000 r-xp /usr/lib/libvconf.so.0.2.45
b7068000 b706b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b706c000 b70ba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70bb000 b721c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7220000 b7227000 r-xp /lib/librt-2.13.so
b722a000 b7231000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7233000 b724d000 r-xp /lib/libgcc_s-4.6.4.so.1
b724e000 b7256000 r-xp /lib/libcrypt-2.13.so
b727f000 b7283000 r-xp /lib/libcap.so.2.21
b7284000 b7286000 r-xp /usr/lib/libiri.so
b7288000 b72b4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72b5000 b72d5000 r-xp /usr/lib/libecore.so.1.7.99
b72e4000 b72ed000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72ee000 b7411000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7412000 b7425000 r-xp /usr/lib/libail.so.0.1.0
b7427000 b744c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b744d000 b7457000 r-xp /lib/libunwind.so.8.0.1
b7461000 b75d2000 r-xp /lib/libc-2.13.so
b75d8000 b7622000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7623000 b7628000 r-xp /usr/lib/libbundle.so.0.1.22
b7629000 b762c000 r-xp /lib/libdl-2.13.so
b762f000 b7634000 r-xp /usr/lib/libsmack.so.1.0.0
b7635000 b76dd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76e0000 b76fa000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76fb000 b7712000 r-xp /lib/libpthread-2.13.so
b7716000 b7719000 r-xp /usr/lib/libdlog.so.0.0.0
b771a000 b772a000 r-xp /usr/lib/libaul.so.0.1.0
b772c000 b7732000 r-xp /usr/lib/libappcore-common.so.1.1
b7733000 b7738000 r-xp /usr/lib/libappcore-efl.so.1.1
b773a000 b773f000 r-xp /usr/lib/libsys-assert.so
b7742000 b7760000 r-xp /lib/ld-2.13.so
b7760000 b7761000 r-xp [vdso]
b7763000 b776a000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:3596)
Call Stack Count: 8
 0: strcat + 0x12d (0xb74d57ad) [/lib/libc.so.6] + 0x747ad
 1: app_create + 0x2f (0xb458119f) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x119f
 2: (0xb6be63cf) [/usr/lib/libcapi-appfw-application.so.0] + 0x13cf
 3: appcore_efl_main + 0x293 (0xb7735d53) [/usr/lib/libappcore-efl.so.1] + 0x2d53
 4: ui_app_main + 0x130 (0xb6be75f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
 5: main + 0x2b0 (0xb4581110) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1110
 6: (0xb77665b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77665b1
 7: __libc_start_main + 0xf3 (0xb747a0f3) [/lib/libc.so.6] + 0x190f3
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
 08:27:46.367+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:27:46.467+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3541
03-18 08:27:46.467+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:27:46.567+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3541
03-18 08:27:46.567+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:27:46.667+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3541
03-18 08:27:46.667+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:27:46.767+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(566) > process launched, but cmdline not changed
03-18 08:27:46.767+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-18 08:27:46.767+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-18 08:27:46.767+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-18 08:27:46.767+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:27:46.767+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:27:46.767+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 08:27:46.767+0900 D/RESOURCED( 2340): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 08:27:46.767+0900 D/RESOURCED( 2340): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2144
03-18 08:27:46.767+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 3541, type 4 
03-18 08:27:46.767+0900 E/RESOURCED( 2340): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/3541/oom_score_adj failed
03-18 08:27:46.767+0900 E/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 3541
03-18 08:27:46.767+0900 D/RESOURCED( 2340): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
03-18 08:27:46.777+0900 D/AUL     ( 2144): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2085, pid = 3567
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 08:27:46.777+0900 D/RESOURCED( 2340): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 08:27:46.777+0900 D/RESOURCED( 2340): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2144
03-18 08:27:46.777+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 3316, type 5 
03-18 08:27:46.777+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(592) > [SECURE_LOG] [resourced_proc_status_change,592] resume request 3316
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __nofork_processing(1008) > __nofork_processing, cmd: 0, pid: 3316
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __nofork_processing(1024) > fake launch pid : 3316
03-18 08:27:46.777+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw_with_delay_reply(435) > pid(3316) : cmd(0)
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_reply_handler(873) > listen fd : 28, send fd : 27
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __nofork_processing(1027) > fake launch done
03-18 08:27:46.777+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3541
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 08:27:46.777+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:27:46.777+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:27:46.777+0900 D/APP_CORE( 3316): appcore.c: __aul_handler(423) > [APP 3316]     AUL event: AUL_START
03-18 08:27:46.777+0900 D/APP_CORE( 3316): appcore-efl.c: __do_app(470) > [APP 3316] Event: RESET State: RUNNING
03-18 08:27:46.777+0900 D/APP_CORE( 3316): appcore-efl.c: __do_app(496) > [APP 3316] RESET
03-18 08:27:46.777+0900 D/LAUNCH  ( 3316): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
03-18 08:27:46.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __reply_handler(784) > listen fd(28) , send fd(27), pid(3316), cmd(0)
03-18 08:27:46.787+0900 D/AUL     ( 3567): launch.c: app_request_to_launchpad(295) > launch request result : 3316
03-18 08:27:46.797+0900 D/LAUNCH  ( 3316): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
03-18 08:27:46.797+0900 I/APP_CORE( 3316): appcore-efl.c: __do_app(514) > Legacy lifecycle: 0
03-18 08:27:46.797+0900 I/APP_CORE( 3316): appcore-efl.c: __do_app(516) > [APP 3316] App already running, raise the window
03-18 08:27:46.797+0900 D/APP_CORE( 3316): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-18 08:27:46.797+0900 D/APP_CORE( 3316): appcore.c: __prt_ltime(183) > [APP 3316] first idle after reset: 17871792 msec
03-18 08:27:47.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __grab_timeout_handler(1212) > pid(3541) ecore_x_pointer_ungrab
03-18 08:27:47.777+0900 D/AUL_AMD ( 2144): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-18 08:27:47.777+0900 D/RUA     ( 2144): rua.c: rua_add_history(179) > rua_add_history start
03-18 08:27:47.777+0900 D/RUA     ( 2144): rua.c: rua_add_history(247) > rua_add_history ok
03-18 08:27:47.777+0900 D/AUL_AMD ( 2144): amd_launch.c: __grab_timeout_handler(1212) > pid(3316) ecore_x_pointer_ungrab
03-18 08:27:47.777+0900 D/AUL_AMD ( 2144): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-18 08:27:47.777+0900 D/RUA     ( 2144): rua.c: rua_add_history(179) > rua_add_history start
03-18 08:27:47.787+0900 D/RUA     ( 2144): rua.c: rua_add_history(247) > rua_add_history ok
03-18 08:28:26.776+0900 D/STARTER ( 2245): hw_key_w.c: _key_press_cb(1107) > [_key_press_cb:1107] _key_press_cb : XF86PowerOff Pressed
03-18 08:28:26.776+0900 W/STARTER ( 2245): hw_key_w.c: _key_press_cb(1112) > [_key_press_cb:1112] POWER Key is pressed
03-18 08:28:26.776+0900 W/STARTER ( 2245): hw_key_w.c: _key_press_cb(1118) > [_key_press_cb:1118] LCD state : 3
03-18 08:28:26.776+0900 E/STARTER ( 2245): hw_key_w.c: _key_press_cb(1127) > [_key_press_cb:1127] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
03-18 08:28:26.776+0900 W/STARTER ( 2245): hw_key_w.c: _key_press_cb(1130) > [_key_press_cb:1130] Simple Clock state : 0
03-18 08:28:26.776+0900 W/STARTER ( 2245): hw_key_w.c: _key_press_cb(1135) > [_key_press_cb:1135] powerkey count : 1
03-18 08:28:26.776+0900 D/STARTER ( 2245): hw_key_w.c: _key_press_cb(1149) > [_key_press_cb:1149] create long press timer
03-18 08:28:26.776+0900 W/W_HOME  ( 2255): dbus.c: _dbus_message_recv_cb(178) > LCD on
03-18 08:28:26.776+0900 W/W_HOME  ( 2255): main.c: _lcd_on_cb(951) > LCD: off->on
03-18 08:28:26.776+0900 D/STARTER ( 2245): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-18 08:28:26.776+0900 W/STARTER ( 2245): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
03-18 08:28:26.776+0900 E/AUL_AMD ( 2144): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
03-18 08:28:26.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-18 08:28:26.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-18 08:28:26.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: preference_get_int(1063) > preference_get_int(2265) : key(clock_font_color) error
03-18 08:28:26.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-18 08:28:26.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-18 08:28:26.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: preference_get_int(1063) > preference_get_int(2265) : key(showdate) error
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Fri 18 Mar][1458257306]
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(857) > 
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458257306]
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[8:28][1458257306]
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(871) > utc_time=8:28, utc_ampm=[2]AM
03-18 08:28:26.776+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>8:28<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-18 08:28:26.796+0900 D/W_HOME  ( 2255): clock_event.c: _display_state_cb(194) > LCD: off->on
03-18 08:28:26.796+0900 D/W_HOME  ( 2255): clock_view.c: clock_view_event_handler(843) > event:40000 received
03-18 08:28:26.796+0900 D/W_HOME  ( 2255): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-18 08:28:26.796+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
03-18 08:28:26.796+0900 D/DATA_PROVIDER_MASTER( 2273): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 08:28:26.796+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
03-18 08:28:26.796+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-18 08:28:26.796+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
03-18 08:28:26.796+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
03-18 08:28:26.896+0900 D/STARTER ( 2245): hw_key_w.c: _key_release_cb(1038) > [_key_release_cb:1038] _key_release_cb : XF86PowerOff Released
03-18 08:28:26.896+0900 W/STARTER ( 2245): hw_key_w.c: _key_release_cb(1043) > [_key_release_cb:1043] POWER Key is released
03-18 08:28:26.896+0900 D/STARTER ( 2245): hw_key_w.c: _key_release_cb(1049) > [_key_release_cb:1049] delete long press timer
03-18 08:28:26.896+0900 D/STARTER ( 2245): hw_key_w.c: _key_release_cb(1075) > [_key_release_cb:1075] lcd off --> [0.400000]sec timer
03-18 08:28:27.296+0900 W/STARTER ( 2245): hw_key_w.c: _powerkey_timer_cb(777) > [_powerkey_timer_cb:777] _powerkey_timer_cb, powerkey count[1]
03-18 08:28:27.296+0900 E/STARTER ( 2245): hw_key_w.c: _powerkey_timer_cb(796) > [SECURE_LOG] [_powerkey_timer_cb:796] Failed to get vconfkey[memory/setup_wizard/state]
03-18 08:28:27.296+0900 E/STARTER ( 2245): hw_key_w.c: _powerkey_timer_cb(825) > [SECURE_LOG] [_powerkey_timer_cb:825] Failed to get vconfkey[db/wms/safety_enable]
03-18 08:28:27.296+0900 W/STARTER ( 2245): hw_key_w.c: _powerkey_timer_cb(891) > [_powerkey_timer_cb:891] just turn on LCD by powerkey.. starter ignore powerkey operation
03-18 08:28:30.016+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 08:28:30.076+0900 D/EFL     ( 3316): ecore_x<3316> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=28330029 button=1
03-18 08:28:30.166+0900 D/EFL     ( 3316): ecore_x<3316> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=28330173 button=1
03-18 08:28:30.166+0900 E/EFL     ( 3316): eina_module<3316> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 08:28:30.176+0900 D/AUL     ( 3316): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-18 08:28:30.176+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 22
03-18 08:28:30.176+0900 D/APP_CORE( 3316): appcore-efl.c: __after_loop(1062) > [APP 3316] PAUSE before termination
03-18 08:28:30.176+0900 E/W_HOME  ( 2255): main.c: _window_focus_in_cb(851) > win[14680067], ev->win[14680071]
03-18 08:28:30.176+0900 D/APPS    ( 2255): apps_main.c: _window_focus_in_cb(288) >  focus in
03-18 08:28:30.176+0900 E/W_HOME  ( 2255): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-18 08:28:30.176+0900 D/APPS    ( 2255): apps_main.c: apps_main_resume(693) >  Resume starts
03-18 08:28:30.176+0900 D/APPS    ( 2255): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-18 08:28:30.176+0900 E/efl-extension( 2255): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb84fd120, elm_scroller, _activated_obj : 0xb84fd120, activated : 1
03-18 08:28:30.226+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3316 pgid = 3316
03-18 08:28:30.226+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(123) > dead_pid(3316)
03-18 08:28:30.226+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 08:28:30.226+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 08:28:30.226+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 08:28:30.226+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(3316) is dead
03-18 08:28:30.226+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 08:28:30.226+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3316)
03-18 08:28:30.226+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3316
03-18 08:28:30.226+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 08:28:30.226+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:28:30.226+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:28:30.926+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 08:28:30.976+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=28330934 button=1
03-18 08:28:30.976+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [192,213]
03-18 08:28:31.116+0900 D/APPS    ( 2255): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-18 08:28:31.616+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=28331601 button=1
03-18 08:28:31.616+0900 D/APPS    ( 2255): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-18 08:28:31.616+0900 D/APPS    ( 2255): scroller.c: _anim_start_cb(122) >  start the scroller animation
03-18 08:28:31.616+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [191,72]
03-18 08:28:31.836+0900 D/APPS    ( 2255): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
03-18 08:28:32.176+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(113) > pid(3316)
03-18 08:28:32.176+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-18 08:28:32.856+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 08:28:32.906+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=28332863 button=1
03-18 08:28:32.906+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [93,255]
03-18 08:28:32.906+0900 D/APPS    ( 2255): item.c: _down_cb(381) >  Down (basicui,0xb87269d8) (93, 255), item pos(6,202,166,144)
03-18 08:28:32.906+0900 E/APPS    ( 2255): item.c: _down_cb(425) >  longpress edit mode disable
03-18 08:28:32.936+0900 W/APPS    ( 2255): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-18 08:28:32.996+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=28333007 button=1
03-18 08:28:32.996+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [93,255]
03-18 08:28:32.996+0900 D/APPS    ( 2255): item.c: _up_cb(573) >  Up (basicui,0xb87269d8) (93, 255), item pos(6,202,166,144)
03-18 08:28:32.996+0900 E/APPS    ( 2255): item.c: _clicked_cb(65) >  Clicked
03-18 08:28:32.996+0900 E/APPS    ( 2255): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-18 08:28:32.996+0900 D/APPS    ( 2255): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-18 08:28:32.996+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 08:28:32.996+0900 D/APP_SVC ( 2255): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-18 08:28:32.996+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 08:28:32.996+0900 D/W_HOME  ( 2255): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-18 08:28:32.996+0900 D/W_HOME  ( 2255): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-18 08:28:32.996+0900 D/APP_SVC ( 2255): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-18 08:28:32.996+0900 D/AUL     ( 2255): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-18 08:28:32.996+0900 D/AUL     ( 2255): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-18 08:28:32.996+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 08:28:32.996+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-18 08:28:32.996+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-18 08:28:33.006+0900 E/AUL_AMD ( 2144): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-18 08:28:33.006+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-18 08:28:33.006+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 08:28:33.006+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 08:28:33.006+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-18 08:28:33.006+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 08:28:33.006+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 08:28:33.006+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-18 08:28:33.006+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 08:28:33.006+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 3596 /opt/usr/apps/org.example.basicui/bin/basicui
03-18 08:28:33.006+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-18 08:28:33.006+0900 D/AUL_PAD ( 3596): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-18 08:28:33.006+0900 D/LAUNCH  ( 3596): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-18 08:28:33.016+0900 I/efl-extension( 3596): efl_extension.c: eext_mod_init(39) > Init
03-18 08:28:33.016+0900 I/CAPI_APPFW_APPLICATION( 3596): app_main.c: ui_app_main(701) > app_efl_main
03-18 08:28:33.016+0900 D/LAUNCH  ( 3596): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-18 08:28:33.036+0900 D/APP_CORE( 3596): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 08:28:33.036+0900 D/AUL     ( 3596): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3596 is org.example.basicui
03-18 08:28:33.036+0900 D/APP_CORE( 3596): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-18 08:28:33.036+0900 D/APP_CORE( 3596): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 08:28:33.036+0900 D/AUL     ( 3596): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 08:28:33.036+0900 D/LAUNCH  ( 3596): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-18 08:28:33.036+0900 I/CAPI_APPFW_APPLICATION( 3596): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 08:28:33.056+0900 E/EFL     ( 3596): eina_module<3596> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 08:28:33.056+0900 E/EFL     ( 3596): ecore_evas<3596> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-18 08:28:33.076+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3596 pgid = 3596
03-18 08:28:33.076+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(123) > dead_pid(3596)
03-18 08:28:33.076+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 08:28:33.076+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 08:28:33.076+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 08:28:33.076+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.076+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.076+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3596)
03-18 08:28:33.186+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.186+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.286+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.286+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.386+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.386+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.486+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.486+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.586+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.586+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.686+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.686+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.796+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.796+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.896+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.896+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:33.996+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:33.996+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.096+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.096+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.196+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.196+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.306+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.306+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.406+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.406+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.506+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.506+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.606+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.606+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.706+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.706+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.806+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.806+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:34.906+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3596
03-18 08:28:34.906+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:35.016+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(566) > process launched, but cmdline not changed
03-18 08:28:35.016+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-18 08:28:35.016+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-18 08:28:35.016+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-18 08:28:35.016+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:28:35.016+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:28:35.016+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3596
03-18 08:28:35.016+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 08:28:35.016+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:28:35.016+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:28:35.016+0900 D/RESOURCED( 2340): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 08:28:35.016+0900 D/RESOURCED( 2340): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2144
03-18 08:28:35.016+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 3596, type 4 
03-18 08:28:35.016+0900 E/RESOURCED( 2340): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/3596/oom_score_adj failed
03-18 08:28:35.016+0900 E/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 3596
03-18 08:28:35.016+0900 D/RESOURCED( 2340): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 08:28:35.016+0900 D/AUL     ( 2255): launch.c: app_request_to_launchpad(295) > launch request result : 3596
03-18 08:28:35.016+0900 D/W_HOME  ( 2255): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.example.basicui:basicui) ret : [0]
03-18 08:28:35.016+0900 D/LAUNCH  ( 2255): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.example.basicui:Menuscreen:launch:done]
03-18 08:28:35.016+0900 W/APPS    ( 2255): item.c: _anim_item_released_cb(1075) >  item is released
03-18 08:28:35.016+0900 D/APPS    ( 2255): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-18 08:28:35.036+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(3596) is dead
03-18 08:28:35.036+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 08:28:36.016+0900 D/AUL_AMD ( 2144): amd_launch.c: __grab_timeout_handler(1212) > pid(3596) ecore_x_pointer_ungrab
03-18 08:28:36.016+0900 D/AUL_AMD ( 2144): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-18 08:28:36.016+0900 D/RUA     ( 2144): rua.c: rua_add_history(179) > rua_add_history start
03-18 08:28:36.026+0900 D/RUA     ( 2144): rua.c: rua_add_history(247) > rua_add_history ok
03-18 08:28:40.516+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 08:28:40.576+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=28340528 button=1
03-18 08:28:40.576+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [89,254]
03-18 08:28:40.576+0900 D/APPS    ( 2255): item.c: _down_cb(381) >  Down (basicui,0xb87269d8) (89, 254), item pos(6,202,166,144)
03-18 08:28:40.576+0900 E/APPS    ( 2255): item.c: _down_cb(425) >  longpress edit mode disable
03-18 08:28:40.596+0900 W/APPS    ( 2255): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-18 08:28:40.676+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=28340680 button=1
03-18 08:28:40.676+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [89,254]
03-18 08:28:40.676+0900 D/APPS    ( 2255): item.c: _up_cb(573) >  Up (basicui,0xb87269d8) (89, 254), item pos(6,202,166,144)
03-18 08:28:40.676+0900 E/APPS    ( 2255): item.c: _clicked_cb(65) >  Clicked
03-18 08:28:40.676+0900 E/APPS    ( 2255): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-18 08:28:40.676+0900 D/APPS    ( 2255): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-18 08:28:40.676+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 08:28:40.676+0900 D/APP_SVC ( 2255): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-18 08:28:40.676+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 08:28:40.676+0900 D/W_HOME  ( 2255): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-18 08:28:40.676+0900 D/W_HOME  ( 2255): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-18 08:28:40.676+0900 D/APP_SVC ( 2255): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-18 08:28:40.676+0900 D/AUL     ( 2255): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-18 08:28:40.676+0900 D/AUL     ( 2255): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-18 08:28:40.676+0900 E/AUL_AMD ( 2144): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-18 08:28:40.676+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 08:28:40.676+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 08:28:40.676+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-18 08:28:40.676+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 08:28:40.676+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 3601 /opt/usr/apps/org.example.basicui/bin/basicui
03-18 08:28:40.676+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-18 08:28:40.676+0900 D/AUL_PAD ( 3601): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-18 08:28:40.676+0900 D/LAUNCH  ( 3601): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-18 08:28:40.686+0900 I/efl-extension( 3601): efl_extension.c: eext_mod_init(39) > Init
03-18 08:28:40.686+0900 I/CAPI_APPFW_APPLICATION( 3601): app_main.c: ui_app_main(701) > app_efl_main
03-18 08:28:40.686+0900 D/LAUNCH  ( 3601): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-18 08:28:40.706+0900 D/APP_CORE( 3601): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 08:28:40.706+0900 D/AUL     ( 3601): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3601 is org.example.basicui
03-18 08:28:40.706+0900 D/APP_CORE( 3601): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-18 08:28:40.706+0900 D/APP_CORE( 3601): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 08:28:40.706+0900 D/AUL     ( 3601): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 08:28:40.706+0900 D/LAUNCH  ( 3601): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-18 08:28:40.706+0900 I/CAPI_APPFW_APPLICATION( 3601): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 08:28:40.726+0900 E/EFL     ( 3601): eina_module<3601> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 08:28:40.736+0900 E/EFL     ( 3601): ecore_evas<3601> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-18 08:28:40.756+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3601 pgid = 3601
03-18 08:28:40.756+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(123) > dead_pid(3601)
03-18 08:28:40.756+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 08:28:40.756+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 08:28:40.756+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 08:28:40.756+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:40.756+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:40.756+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3601)
03-18 08:28:40.856+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:40.856+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:40.956+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:40.956+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.056+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.056+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.156+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.156+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.266+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.266+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.366+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.366+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.466+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.466+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.566+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.566+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.666+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.666+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.766+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.766+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.876+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.876+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:41.976+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:41.976+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.076+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:42.076+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.176+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:42.176+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.276+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:42.276+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.376+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:42.376+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.476+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:42.476+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.576+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3601
03-18 08:28:42.576+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 08:28:42.676+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(566) > process launched, but cmdline not changed
03-18 08:28:42.676+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-18 08:28:42.676+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-18 08:28:42.676+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-18 08:28:42.676+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:28:42.676+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:28:42.676+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3601
03-18 08:28:42.676+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 08:28:42.676+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 08:28:42.676+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 08:28:42.676+0900 D/RESOURCED( 2340): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 08:28:42.676+0900 D/RESOURCED( 2340): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2144
03-18 08:28:42.676+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 3601, type 4 
03-18 08:28:42.676+0900 E/RESOURCED( 2340): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/3601/oom_score_adj failed
03-18 08:28:42.676+0900 E/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 3601
03-18 08:28:42.676+0900 D/RESOURCED( 2340): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 08:28:42.676+0900 D/AUL     ( 2255): launch.c: app_request_to_launchpad(295) > launch request result : 3601
03-18 08:28:42.676+0900 D/W_HOME  ( 2255): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.example.basicui:basicui) ret : [0]
03-18 08:28:42.676+0900 D/LAUNCH  ( 2255): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.example.basicui:Menuscreen:launch:done]
03-18 08:28:42.696+0900 W/APPS    ( 2255): item.c: _anim_item_released_cb(1075) >  item is released
03-18 08:28:42.696+0900 D/APPS    ( 2255): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-18 08:28:42.696+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(3601) is dead
03-18 08:28:42.696+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 08:28:43.066+0900 W/CRASH_MANAGER( 3607): worker.c: worker_job(1189) > 1103596626173145825731
