require 'test_helper'

class DmnhomnhaccsControllerTest < ActionController::TestCase
  setup do
    @dmnhomnhacc = dmnhomnhaccs(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnhomnhaccs)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhomnhacc" do
    assert_difference('Dmnhomnhacc.count') do
      post :create, dmnhomnhacc: { stt: @dmnhomnhacc.stt, ten: @dmnhomnhacc.ten }
    end

    assert_redirected_to dmnhomnhacc_path(assigns(:dmnhomnhacc))
  end

  test "should show dmnhomnhacc" do
    get :show, id: @dmnhomnhacc
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhomnhacc
    assert_response :success
  end

  test "should update dmnhomnhacc" do
    patch :update, id: @dmnhomnhacc, dmnhomnhacc: { stt: @dmnhomnhacc.stt, ten: @dmnhomnhacc.ten }
    assert_redirected_to dmnhomnhacc_path(assigns(:dmnhomnhacc))
  end

  test "should destroy dmnhomnhacc" do
    assert_difference('Dmnhomnhacc.count', -1) do
      delete :destroy, id: @dmnhomnhacc
    end

    assert_redirected_to dmnhomnhaccs_path
  end
end
