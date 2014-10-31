require 'test_helper'

class DmttbsControllerTest < ActionController::TestCase
  setup do
    @dmttb = dmttbs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmttbs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmttb" do
    assert_difference('Dmttb.count') do
      post :create, dmttb: { congsuat: @dmttb.congsuat, dmdvt_id: @dmttb.dmdvt_id, dmhangsx_id: @dmttb.dmhangsx_id, dmnhom_id: @dmttb.dmnhom_id, dmnhombc_id: @dmttb.dmnhombc_id, dmnhomin_id: @dmttb.dmnhomin_id, dmnuocsx_id: @dmttb.dmnuocsx_id, hamluong: @dmttb.hamluong, hinh: @dmttb.hinh, ma: @dmttb.ma, model: @dmttb.model, sodk: @dmttb.sodk, sothe: @dmttb.sothe, stt: @dmttb.stt, ten: @dmttb.ten, tylekh: @dmttb.tylekh }
    end

    assert_redirected_to dmttb_path(assigns(:dmttb))
  end

  test "should show dmttb" do
    get :show, id: @dmttb
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmttb
    assert_response :success
  end

  test "should update dmttb" do
    patch :update, id: @dmttb, dmttb: { congsuat: @dmttb.congsuat, dmdvt_id: @dmttb.dmdvt_id, dmhangsx_id: @dmttb.dmhangsx_id, dmnhom_id: @dmttb.dmnhom_id, dmnhombc_id: @dmttb.dmnhombc_id, dmnhomin_id: @dmttb.dmnhomin_id, dmnuocsx_id: @dmttb.dmnuocsx_id, hamluong: @dmttb.hamluong, hinh: @dmttb.hinh, ma: @dmttb.ma, model: @dmttb.model, sodk: @dmttb.sodk, sothe: @dmttb.sothe, stt: @dmttb.stt, ten: @dmttb.ten, tylekh: @dmttb.tylekh }
    assert_redirected_to dmttb_path(assigns(:dmttb))
  end

  test "should destroy dmttb" do
    assert_difference('Dmttb.count', -1) do
      delete :destroy, id: @dmttb
    end

    assert_redirected_to dmttbs_path
  end
end
