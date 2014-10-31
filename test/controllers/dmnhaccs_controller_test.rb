require 'test_helper'

class DmnhaccsControllerTest < ActionController::TestCase
  setup do
    @dmnhacc = dmnhaccs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnhaccs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhacc" do
    assert_difference('Dmnhacc.count') do
      post :create, dmnhacc: { daidien: @dmnhacc.daidien, diachi: @dmnhacc.diachi, dmnhomnhacc_id: @dmnhacc.dmnhomnhacc_id, dt: @dmnhacc.dt, masothue: @dmnhacc.masothue, sotk: @dmnhacc.sotk, stt: @dmnhacc.stt, ten: @dmnhacc.ten }
    end

    assert_redirected_to dmnhacc_path(assigns(:dmnhacc))
  end

  test "should show dmnhacc" do
    get :show, id: @dmnhacc
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhacc
    assert_response :success
  end

  test "should update dmnhacc" do
    patch :update, id: @dmnhacc, dmnhacc: { daidien: @dmnhacc.daidien, diachi: @dmnhacc.diachi, dmnhomnhacc_id: @dmnhacc.dmnhomnhacc_id, dt: @dmnhacc.dt, masothue: @dmnhacc.masothue, sotk: @dmnhacc.sotk, stt: @dmnhacc.stt, ten: @dmnhacc.ten }
    assert_redirected_to dmnhacc_path(assigns(:dmnhacc))
  end

  test "should destroy dmnhacc" do
    assert_difference('Dmnhacc.count', -1) do
      delete :destroy, id: @dmnhacc
    end

    assert_redirected_to dmnhaccs_path
  end
end
