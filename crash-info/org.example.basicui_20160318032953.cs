S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:39

Crash Information
Process Name: basicui
PID: 3289
Date: 2016-03-18 03:29:53+0900
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
MemFree:        48 KB
Buffers:         6 KB
Cached:     138836 KB
VmPeak:      70196 KB
VmSize:      70196 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12576 KB
VmRSS:       12576 KB
VmData:      11428 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31784 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3289 TID = 3289
3289 3293 

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

Callstack Information (PID:3289)
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
-installer( 3232): c3VuZyBFbGVjdHJvbmljcyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEgMB4GA1UEAwwXU2Ft
03-18 03:29:50.142+0900 D/rpm-installer( 3232): c3VuZyBBdXRob3IgQ0EgQ2xhc3MxIDAeBgkqhkiG9w0BCQEWEXRpemVuQHNhbXN1bmcuY29tMIIB
03-18 03:29:50.142+0900 D/rpm-installer( 3232): IjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAs+tRBgnKJs8j7BFg8/UftqbqTCYBV3Jrg1vK
03-18 03:29:50.142+0900 D/rpm-installer( 3232): YvEuoTfntYz2uT2SO67raiCsZBAYvJnP54ExkdV++UgB7BDGniWz7bA1pYKak5kNK5jtLQt2DmZX
03-18 03:29:50.142+0900 D/rpm-installer( 3232): 3qgaLjMyoAz+293CxrBQO4h8NaTQGsO/WLpeQq2Y1ZEnHsq+EUn90H6Vm0HNW+KUayGPYdey+QSW
03-18 03:29:50.142+0900 D/rpm-installer( 3232): iiv+L++TSuHrw0b16GYn83emiTnKTCmwpSOZ712Gy9kccl46/K4C8skEDVZjTk9s7r/MN9ZNZsqR
03-18 03:29:50.142+0900 D/rpm-installer( 3232): brT/3AYcrF4ao8ipwlHK91WJBXXaiQICvp/dNfCSDWpTWy7z4XmgP16pSLnfgZlwEwWfiaavHRNM
03-18 03:29:50.142+0900 D/rpm-installer( 3232): mwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQB/ZlNMTzlIHqC3mFSq
03-18 03:29:50.142+0900 D/rpm-installer( 3232): ptuQDZG9
03-18 03:29:50.172+0900 D/PKGMGR  ( 2095): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.basicui_-791170240 / coretpk / org.example.basicui / start / update
03-18 03:29:50.172+0900 D/PKGMGR  ( 2095): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[start] val[update]
03-18 03:29:50.172+0900 D/PKGMGR  ( 2095): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.172+0900 D/PKGMGR  ( 2095): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.172+0900 D/rpm-installer( 3232): rpm-installer.c: _ri_verify_sig_and_cert(1921) > cert_svc_verify() is done successfully. validity=[1]
03-18 03:29:50.172+0900 D/rpm-installer( 3232): rpm-installer.c: _ri_verify_sig_and_cert(1932) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/Tizen_Developers_Root_Class.pem]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): rpm-installer.c: __ri_verify_file(407) > valid signature
03-18 03:29:50.182+0900 D/rpm-installer( 3232): rpm-installer.c: __ri_get_cert_from_file(1066) > Root CA, len=[1136]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): MIIDTzCCAjegAwIBAgIJALddlYde0wE9MA0GCSqGSIb3DQEBCwUAMF4xGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEkMCIGA1UEAwwbVGl6ZW4gRGV2ZWxvcGVycyBSb290IENsYXNzMB4XDTEzMTIzMDE1MDQxMFoXDTMzMTIyNTE1MDQxMFowXjEaMBgGA1UECgwRVGl6ZW4gQXNzb2NpYXRpb24xGjAYBgNVBAsMEVRpemVuIEFzc29jaWF0aW9uMSQwIgYDVQQDDBtUaXplbiBEZXZlbG9wZXJzIFJvb3QgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDRUet02YnWItxNZzZc+o2WqH3LrJh70mCY/B9jlw9ckKKABD39glT17KaW+ZKFyN9M3h/wd2SU5g3CkwMMNOIrFLTB3YryR/aH+3ps6c8RqSUJG+6klFOaXuiG0kCzxvwVA+T+8z7zZKeBj6D6AooA6BpKgflu9J94KQqT3/y5IABQLm3SrB4iclabdT3Y+ZEBz63yNcHqJTpjqQw/wB3LV5a0i/Y/MjPn8Oogkgh/edJvIklUXcZC5Ac1tYB+ZZLKvROqUrPyzFOyPMU/EnoXRYX+PBiLtG+34o0Orw31Ifjs/r0AFs5qsLjR37YB9x5IWSwfTJuZcSPtyO1nDeNDAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAJ60YDkQ8IPBZoamDMoxkNlKFxv5azN7eeD5nO1h9ASzz3HI5wa9Iry67l0MBjio3caLHjCnV9KzllXMBNCL6Dv0fBpFUadU57lfX5raH7ELGlpplyj1aVQlHm3zvF8eXGu6zmdS0Vdw/NOGaNuIwm/xUUCkeJyPWM
03-18 03:29:50.182+0900 D/rpm-installer( 3232): rpm-installer.c: _ri_verify_sig_and_cert(1956) > cert_svc_get_visibility() returns visibility=[1]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_verify_signatures(877) > _ri_verify_sig_and_cert succeed, path=[/opt/usr/apps/org.example.basicui/author-signature.xml]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_verify_signatures(888) > signature1.xml is found, path=[/opt/usr/apps/org.example.basicui]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): rpm-installer-signature.c: _ri_process_signaturevalue(562) > SignatureValue, len=[350]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): 
03-18 03:29:50.182+0900 D/rpm-installer( 3232): Ql9HLzTtni0f2PmAXYJ3ZX8Zlu1dDpBQhEL/sfuIopLEfRrHWtinYfGHsMAltVIV2XEgH3nXabjd
03-18 03:29:50.182+0900 D/rpm-installer( 3232): lYay2knEQhSMzuX+QO65NVq4AJK1Gk/AJtM0tq+vV3ibsaB1Ee0FIWwOv5DVi9BMM0h5T7xZRH1k
03-18 03:29:50.182+0900 D/rpm-installer( 3232): /jiSbOm2kpbseHNDF1744SD1nTQdjQVgQzeT+E3pdlQg1+uBz7ZmKt+IcK7PQDXNX9AiEb88Pu4F
03-18 03:29:50.182+0900 D/rpm-installer( 3232): P8+AuNW0Sm7hyR0/JNrsEMxkpNx4rInMq3PjF5hyVsY/zLqw8sh4HKFj3xlv2RN7KCn4HsgC2/mQ
03-18 03:29:50.182+0900 D/rpm-installer( 3232): 4khNW/Y5zxnuFamvw66vqGePcgvYt51alDThVw==
03-18 03:29:50.182+0900 D/rpm-installer( 3232): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1306]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): 
03-18 03:29:50.182+0900 D/rpm-installer( 3232): MIIDwDCCAqigAwIBAgIBZDANBgkqhkiG9w0BAQsFADCBvDELMAkGA1UEBhMCS1IxFDASBgNVBAgM
03-18 03:29:50.182+0900 D/rpm-installer( 3232): C1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmlj
03-18 03:29:50.182+0900 D/rpm-installer( 3232): cyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEoMCYGA1UEAwwfR0VBUjIgREVWRUxPUEVSIFB1
03-18 03:29:50.182+0900 D/rpm-installer( 3232): YmxpYyBDQSBDbGFzczEkMCIGCSqGSIb3DQEJARYVZ2VhcjIuc2VjQHNhbXN1bmcuY29tMB4XDTE2
03-18 03:29:50.182+0900 D/rpm-installer( 3232): MDMxNTE4MTk1M1oXDTE3MDMxNTE4MTk1M1owbjERMA8GA1UEAwwIVGl6ZW5TREsxCTAHBgNVBAsM
03-18 03:29:50.182+0900 D/rpm-installer( 3232): ADEJMAcGA1UECgwAMQkwBwYDVQQHDAAxCTAHBgNVBAgMADEJMAcGA1UEBhMAMSIwIAYJKoZIhvcN
03-18 03:29:50.182+0900 D/rpm-installer( 3232): AQkBFhNlLnJvc2thY2hAZ21haWwuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA
03-18 03:29:50.182+0900 D/rpm-installer( 3232): xhYuv0nyolP8j97CjxclvEpRaJY8G0cWZ2Duj6LO2cJpr32zZYLMPtg1yhZ9VDowq+taqmc4hs0j
03-18 03:29:50.182+0900 D/rpm-installer( 3232): 2Tr4Q88c73girso2yNWOLy709CMfge4cwmXPq91pLLKggBDr5hpHveBdff0AQfLoK3KxVVAzos4O
03-18 03:29:50.182+0900 D/rpm-installer( 3232): fRRUBab88uW9Srf01Ew6kSW9cyshgk6ymEuio9LSQ2Qfz4Y+wPSOATsUcRR5PP8Igyc871qNKlmD
03-18 03:29:50.182+0900 D/rpm-installer( 3232): +SNn0IrIEKr3fikA4ZstNRIpYLF6fcO7bBYo0mqq+wcgCMRtUDBhBbA5/xXXKfp0zOQv2J9bSNNG
03-18 03:29:50.182+0900 D/rpm-installer( 3232): aRYzmnefWp0BjGngF2/yFSfgfOKtapOI4Kn2uwIDAQABoxowGDAJBgNVHRMEAjAAMAsGA1UdDwQE
03-18 03:29:50.182+0900 D/rpm-installer( 3232): AwIHgDAN
03-18 03:29:50.182+0900 D/rpm-installer( 3232): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1404]
03-18 03:29:50.182+0900 D/rpm-installer( 3232): 
03-18 03:29:50.182+0900 D/rpm-installer( 3232): MIIECDCCAvCgAwIBAgICMp0wDQYJKoZIhvcNAQELBQAwgb4xCzAJBgNVBAYTAktSMRQwEgYDVQQI
03-18 03:29:50.182+0900 D/rpm-installer( 3232): DAtTb3V0aCBLb3JlYTEOMAwGA1UEBwwFU3V3b24xJjAkBgNVBAoMHVNhbXN1bmcgRWxlY3Ryb25p
03-18 03:29:50.182+0900 D/rpm-installer( 3232): Y3MgQ28uLCBMdGQuMQ8wDQYDVQQLDAZNb2JpbGUxKjAoBgNVBAMMIUdFQVIyIERFVkVMT1BFUiBQ
03-18 03:29:50.182+0900 D/rpm-installer( 3232): dWJsaWMgUm9vdCBDbGFzczEkMCIGCSqGSIb3DQEJARYVZ2VhcjIuc2VjQHNhbXN1bmcuY29tMB4X
03-18 03:29:50.182+0900 D/rpm-installer( 3232): DTEzMTIzMDE1MDA0MVoXDTI4MTIyNjE1MDA0MVowgbwxCzAJBgNVBAYTAktSMRQwEgYDVQQIDAtT
03-18 03:29:50.182+0900 D/rpm-installer( 3232): b3V0aCBLb3JlYTEOMAwGA1UEBwwFU3V3b24xJjAkBgNVBAoMHVNhbXN1bmcgRWxlY3Ryb25pY3Mg
03-18 03:29:50.182+0900 D/rpm-installer( 3232): Q28uLCBMdGQuMQ8wDQYDVQQLDAZNb2JpbGUxKDAmBgNVBAMMH0dFQVIyIERFVkVMT1BFUiBQdWJs
03-18 03:29:50.182+0900 D/rpm-installer( 3232): aWMgQ0EgQ2xhc3MxJDAiBgkqhkiG9w0BCQEWFWdlYXIyLnNlY0BzYW1zdW5nLmNvbTCCASIwDQYJ
03-18 03:29:50.182+0900 D/rpm-installer( 3232): KoZIhvcNAQEBBQADggEPADCCAQoCggEBAJ/RgN3VyfWdM1j/2/suXWPbTxs5WHvz08VSTf1FjE3t
03-18 03:29:50.182+0900 D/rpm-installer( 3232): JsBr1EtcdGbDQtp6GM63RCePxB6ckwr+jFcEwWHcOLqm1ywCysbRLhDSsaj4nWDhwuF1kFmwBC9l
03-18 03:29:50.182+0900 D/rpm-installer( 3232): 7lktPATwiHIYpCxgrDez61NLn8gMspJr2fNraTKgNik0yw2COQ3VTlLqUm8dm2nIGM+HJZcK2O/S
03-18 03:29:50.182+0900 D/rpm-installer( 3232): GEzyEb9ohHF4JoU3oTXk2y1070b2U+Nb0b3IzJSYzJlPdHW+buUVKjEBtnDkggWuq1oh2iXzsKaH
03-18 03:29:50.182+0900 D/rpm-installer( 3232): qllCQOts
03-18 03:29:50.212+0900 D/rpm-installer( 3232): rpm-installer.c: _ri_verify_sig_and_cert(1921) > cert_svc_verify() is done successfully. validity=[1]
03-18 03:29:50.212+0900 D/rpm-installer( 3232): rpm-installer.c: _ri_verify_sig_and_cert(1932) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/gear_test_public.pem]
03-18 03:29:50.222+0900 D/rpm-installer( 3232): rpm-installer.c: __ri_verify_file(407) > valid signature
03-18 03:29:50.222+0900 D/rpm-installer( 3232): rpm-installer.c: __ri_get_cert_from_file(1066) > Root CA, len=[1396]
03-18 03:29:50.222+0900 D/rpm-installer( 3232): MIIEETCCAvmgAwIBAgIJAMUv76y5poSYMA0GCSqGSIb3DQEBCwUAMIG+MQswCQYDVQQGEwJLUjEUMBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVsZWN0cm9uaWNzIENvLiwgTHRkLjEPMA0GA1UECwwGTW9iaWxlMSowKAYDVQQDDCFHRUFSMiBERVZFTE9QRVIgUHVibGljIFJvb3QgQ2xhc3MxJDAiBgkqhkiG9w0BCQEWFWdlYXIyLnNlY0BzYW1zdW5nLmNvbTAeFw0xMzEyMzAxNTAwMzlaFw0zMzEyMjUxNTAwMzlaMIG+MQswCQYDVQQGEwJLUjEUMBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVsZWN0cm9uaWNzIENvLiwgTHRkLjEPMA0GA1UECwwGTW9iaWxlMSowKAYDVQQDDCFHRUFSMiBERVZFTE9QRVIgUHVibGljIFJvb3QgQ2xhc3MxJDAiBgkqhkiG9w0BCQEWFWdlYXIyLnNlY0BzYW1zdW5nLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAML+iLQ1Ih/NEgMvVjHICxyISLna4aI6uVdr+iUHXEGbvOQCcKsuo3quWa34WU3wfUbhLK0W4YIfqbkSotL/9gye3dD0qfPzACnrJI20EbuXXJ/LvVvstPQNV7G7Zzpsg2j1yM950c4jnYRN4PbcM7N/d3xvDbY5Mg2mUYcyd87h8a64KIJQPrjhTL0Xa8c/Ne3lydymdgwFgv8D2Sf97Gxs4lyhYGmCIaGWVPWbQReByWAqqfbnudJRsyuH1SljZPvqFafK3b+CkE0zZYw2c0ff5wuEot56BvgNxWE2L8+nkK
03-18 03:29:50.222+0900 D/rpm-installer( 3232): rpm-installer.c: _ri_verify_sig_and_cert(1956) > cert_svc_get_visibility() returns visibility=[64]
03-18 03:29:50.222+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_verify_signatures(895) > _ri_verify_sig_and_cert() succeed, path=[/opt/usr/apps/org.example.basicui/signature1.xml]
03-18 03:29:50.222+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_package_reinstall(3345) > signature and certificate verifying success
03-18 03:29:50.222+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2372): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2273): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/DATA_PROVIDER_MASTER( 2273): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2279): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/ADD_VIEWER( 2255): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/W_HOME  ( 2255): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/APPS    ( 2255): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.basicui
03-18 03:29:50.222+0900 D/APPS    ( 2255): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 60
03-18 03:29:50.222+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-18 03:29:50.222+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.222+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 4
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 4
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 4
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 4
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 4
03-18 03:29:50.222+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 4
03-18 03:29:50.232+0900 E/PKGMGR_CERT( 3232): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_make_directory(1586) > mkdir failed. appdir=[/usr/apps/org.example.basicui/shared], errno=[2][No such file or directory]
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared]
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared/res]
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/tizen-manifest.xml]
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/author-signature.xml]
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/signature1.xml]
03-18 03:29:50.232+0900 E/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/share/packages/org.example.basicui.xml]
03-18 03:29:50.232+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-18 03:29:50.252+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_unregister_package(84) > [smack] app_uninstall(org.example.basicui), result=[0]
03-18 03:29:50.262+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.basicui), result=[0]
03-18 03:29:50.272+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui, 5, _), result=[0]
03-18 03:29:50.272+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared, 5, _), result=[0]
03-18 03:29:50.272+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/res, 5, _), result=[0]
03-18 03:29:50.282+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/data, 2), result=[0]
03-18 03:29:50.282+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_get_group_id(1866) > encoding done, len=[28]
03-18 03:29:50.282+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_apply_smack(1974) > groupid = [682QedHw7g5Hf0gJXcIO5I3Okls=] for shared/trusted.
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/trusted, 1, 682QedHw7g5Hf0gJXcIO5I3Okls=), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/bin, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/lib, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/res, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/tizen-manifest.xml, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/author-signature.xml, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/signature1.xml, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/share/packages/org.example.basicui.xml, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui, 5, _), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-18 03:29:50.292+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-18 03:29:50.302+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared, 5, _), result=[0]
03-18 03:29:50.312+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared/data, 2), result=[0]
03-18 03:29:50.322+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-18 03:29:50.322+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-18 03:29:50.332+0900 D/rpm-installer( 3232): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-18 03:29:50.332+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_package_reinstall(3437) > #permission applying success.
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/DATA_PROVIDER_MASTER( 2273): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/ADD_VIEWER( 2255): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/W_HOME  ( 2255): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/APPS    ( 2255): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.basicui
03-18 03:29:50.332+0900 D/APPS    ( 2255): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / install_percent / 100
03-18 03:29:50.332+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-18 03:29:50.332+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/rpm-installer( 3232): coretpk-installer.c: _coretpk_installer_package_reinstall(3468) > [#]end : _coretpk_installer_package_reinstall
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2372): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.332+0900 D/DATA_PROVIDER_MASTER( 2273): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.basicui] ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2273): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2279): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.332+0900 D/ADD_VIEWER( 2255): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.basicui] ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.332+0900 D/W_HOME  ( 2255): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:end val:ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.332+0900 D/PKGMGR  ( 2255): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.332+0900 D/APPS    ( 2255): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.basicui
03-18 03:29:50.332+0900 D/APPS    ( 2255): pkgmgr.c: _end(651) >  Package(org.example.basicui) : key(update) - val(ok)
03-18 03:29:50.342+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.342+0900 D/PKGMGR  ( 2241): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.342+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.342+0900 D/PKGMGR  ( 2241): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.342+0900 D/PKGMGR  ( 2144): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.342+0900 D/PKGMGR  ( 2144): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.342+0900 D/AUL_AMD ( 2144): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.basicui), key(end), value(ok)
03-18 03:29:50.342+0900 D/AUL_AMD ( 2144): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(update), value(ok)
03-18 03:29:50.342+0900 D/AUL_AMD ( 2144): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-18 03:29:50.342+0900 D/AUL_AMD ( 2144): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.basicui, comp:ui, type:rpm
03-18 03:29:50.342+0900 D/PKGMGR  ( 2144): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.342+0900 D/PKGMGR  ( 2144): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.342+0900 D/PKGMGR  ( 2095): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.basicui_-791170240 / coretpk / org.example.basicui / end / ok
03-18 03:29:50.342+0900 D/PKGMGR  ( 2095): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.basicui_-791170240] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-18 03:29:50.342+0900 E/PKGMGR_INFO( 2095): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-18 03:29:50.342+0900 D/PKGMGR  ( 2095): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.342+0900 D/PKGMGR  ( 2095): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:50.342+0900 D/rpm-installer( 3232): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-18 03:29:50.342+0900 D/rpm-installer( 3232): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-18 03:29:50.352+0900 D/APPS    ( 2255): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.basicui]
03-18 03:29:50.352+0900 D/APPS    ( 2255): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.basicui]'s item object
03-18 03:29:50.352+0900 D/APPS    ( 2255): db.c: apps_db_remove_item(404) >  Remove the item[org.example.basicui]
03-18 03:29:50.352+0900 D/rpm-installer( 3232): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-18 03:29:50.362+0900 D/APPS    ( 2255): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-18 03:29:50.362+0900 D/APPS    ( 2255): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-18 03:29:50.362+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [49]
03-18 03:29:50.362+0900 D/PKGMGR_SERVER( 3231): pkgmgr-server.c: sighandler(326) > child exit [3232]
03-18 03:29:50.362+0900 D/PKGMGR_SERVER( 3231): pkgmgr-server.c: sighandler(341) > child NORMAL exit [3232]
03-18 03:29:50.362+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-18 03:29:50.362+0900 D/BADGE   ( 2273): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-18 03:29:50.362+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-18 03:29:50.362+0900 E/DATA_PROVIDER_MASTER( 2273): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-18 03:29:50.362+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2273, fd: -1
03-18 03:29:50.362+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2273), fd: -1
03-18 03:29:50.362+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 47 (recv_fd: -1)
03-18 03:29:50.362+0900 D/APPS    ( 2255): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-18 03:29:50.362+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [52]
03-18 03:29:50.362+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-18 03:29:50.362+0900 D/COM_CORE( 2273): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-18 03:29:50.362+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8a13c58 is terminated (NIL packet)
03-18 03:29:50.372+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-18 03:29:50.372+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-18 03:29:50.372+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-18 03:29:50.372+0900 D/BADGE   ( 2273): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-18 03:29:50.372+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-18 03:29:50.372+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2273, fd: -1
03-18 03:29:50.372+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2273), fd: -1
03-18 03:29:50.372+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 47 (recv_fd: -1)
03-18 03:29:50.372+0900 D/APPS    ( 2255): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-18 03:29:50.372+0900 D/APPS    ( 2255): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-18 03:29:50.382+0900 D/COM_CORE( 2273): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-18 03:29:50.382+0900 D/BADGE   ( 2255): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-18 03:29:50.382+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-18 03:29:50.382+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [S80gBD4gGw.Basic]'s ordering : 1
03-18 03:29:50.382+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.accel]'s ordering : 2
03-18 03:29:50.382+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [NxjvjzJaRh.Basic]'s ordering : 3
03-18 03:29:50.382+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 4
03-18 03:29:50.382+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-18 03:29:50.382+0900 E/DATA_PROVIDER_MASTER( 2273): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-18 03:29:50.382+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8a13a18 is terminated (NIL packet)
03-18 03:29:50.382+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-18 03:29:50.382+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[S80gBD4gGw.Basic:1]
03-18 03:29:50.392+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[org.example.accel:2]
03-18 03:29:50.392+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[NxjvjzJaRh.Basic:3]
03-18 03:29:50.402+0900 D/APPS    ( 2255): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:4]
03-18 03:29:50.412+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 03:29:50.412+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 03:29:51.992+0900 D/PKGMGR_SERVER( 3231): pkgmgr-server.c: exit_server(724) > exit_server Start
03-18 03:29:51.992+0900 D/PKGMGR_SERVER( 3231): pkgmgr-server.c: main(1516) > Quit main loop.
03-18 03:29:51.992+0900 D/PKGMGR_SERVER( 3231): pkgmgr-server.c: main(1524) > package manager server terminated.
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-18 03:29:53.622+0900 D/AUL     ( 2144): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 3286, pid = 3288
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-18 03:29:53.622+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 03:29:53.622+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 03:29:53.622+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-18 03:29:53.622+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 03:29:53.622+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 3289 /opt/usr/apps/org.example.basicui/bin/basicui
03-18 03:29:53.622+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 03:29:53.622+0900 D/AUL_PAD ( 3289): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 03:29:53.622+0900 D/AUL_PAD ( 3289): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 03:29:53.622+0900 D/AUL_PAD ( 3289): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-18 03:29:53.632+0900 D/AUL_PAD ( 3289): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 03:29:53.632+0900 D/AUL_PAD ( 3289): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-18 03:29:53.632+0900 D/AUL_PAD ( 3289): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-18 03:29:53.632+0900 D/AUL_PAD ( 3289): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-18 03:29:53.632+0900 D/LAUNCH  ( 3289): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-18 03:29:53.642+0900 I/efl-extension( 3289): efl_extension.c: eext_mod_init(39) > Init
03-18 03:29:53.642+0900 I/CAPI_APPFW_APPLICATION( 3289): app_main.c: ui_app_main(701) > app_efl_main
03-18 03:29:53.642+0900 D/LAUNCH  ( 3289): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-18 03:29:53.652+0900 D/APP_CORE( 3289): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 03:29:53.652+0900 D/AUL     ( 3289): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3289 is org.example.basicui
03-18 03:29:53.652+0900 D/APP_CORE( 3289): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-18 03:29:53.652+0900 D/APP_CORE( 3289): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 03:29:53.652+0900 D/AUL     ( 3289): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 03:29:53.652+0900 D/LAUNCH  ( 3289): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-18 03:29:53.652+0900 I/CAPI_APPFW_APPLICATION( 3289): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 03:29:53.672+0900 E/EFL     ( 3289): eina_module<3289> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 03:29:53.682+0900 E/EFL     ( 3289): ecore_evas<3289> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-18 03:29:53.712+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(142) > dead_pid = 3289 pgid = 3289
03-18 03:29:53.712+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(123) > dead_pid(3289)
03-18 03:29:53.712+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 03:29:53.712+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 03:29:53.712+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 03:29:53.712+0900 E/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 3289
03-18 03:29:53.712+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 03:29:53.712+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(3289) is dead
03-18 03:29:53.712+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 03:29:53.712+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3289)
03-18 03:29:53.712+0900 W/CRASH_MANAGER( 3294): worker.c: worker_job(1189) > 1103289626173145823939
